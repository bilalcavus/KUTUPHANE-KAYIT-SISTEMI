using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;


namespace Login
{
    public partial class Admin : Form
    {

        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\kutuphane.accdb";
        public Admin()
        {
            InitializeComponent();
        }

        //Show Data
        private void showInfo()
        {
            listView1.Items.Clear();
            using(var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using(var cmd = new  OleDbCommand("SELECT * FROM admin", con))
                {
                    using(var dr =  cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["adminID"].ToString();
                                addNew.SubItems.Add(dr["adminName"].ToString());
                                addNew.SubItems.Add(dr["adminGorev"].ToString());
                                addNew.SubItems.Add(dr["adminPass"].ToString());

                                listView1.Items.Add(addNew);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ListView'e veri yüklenirken hata oluştu:" + ex.Message);
                        }
                        finally { con.Close(); }
                        
                    }
                }
            }
        }
       
        //Inserting Data
        private void button1_Click(object sender, EventArgs e)
        {
           using(var con = new OleDbConnection(connectionString))
            {
                con.Open() ;
                using(var cmd = new OleDbCommand("INSERT INTO admin(adminID,adminName,adminGorev,adminPass) VALUES(@adminID,@adminName,@adminGorev,@adminPass)", con))
                {
                    try
                    {
                        string ID = DocIdtxt.Text;
                        string NAME = DocNametxt.Text;
                        string EXPERIENCE = DocExptxt.Text;
                        string PASSWORD = Passwordtxt.Text;

                        // Hash the password
                        string hashedPassword = ComputeHash(PASSWORD);

                        cmd.Parameters.AddWithValue("@adminID", ID);
                        cmd.Parameters.AddWithValue("@adminName", NAME);
                        cmd.Parameters.AddWithValue("@adminGorev", EXPERIENCE);
                        cmd.Parameters.AddWithValue("@adminPass", hashedPassword);

                        cmd.ExecuteNonQuery();

                        ListViewItem newItem = new ListViewItem(ID);
                        newItem.SubItems.Add(NAME);
                        newItem.SubItems.Add(EXPERIENCE);
                        newItem.SubItems.Add(hashedPassword); // Store hashed password in the ListView

                        MessageBox.Show("Admin Başarıyla Eklendi");

                        showInfo();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Cannot insert data. Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        // Function to compute SHA-256 hash
        private string ComputeHash(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        //Update Data
        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE admin SET adminName=?, adminGorev=?, adminPass=? WHERE adminID=?", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@adminName", DocNametxt.Text);
                        cmd.Parameters.AddWithValue("@adminGorev", DocExptxt.Text);
                        cmd.Parameters.AddWithValue("@adminPass", Passwordtxt.Text);
                        cmd.Parameters.AddWithValue("@adminID", DocIdtxt.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin Başarıyla Güncellendi");

                            showInfo();
                        }
                        else
                        {
                            MessageBox.Show("Admin Kimliği için eşleşen kayıt bulunamadı");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Cannot update data. Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }



        //Delete Codes
        private void button4_Click(object sender, EventArgs e)
        {
            if (DocIdtxt.Text == "")
            {
                MessageBox.Show("Admin ID Giriniz");
            }
            else
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    using (var cmd = new OleDbCommand("DELETE FROM admin WHERE adminID=@adminID", con))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@adminID", DocIdtxt.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Admin Silindi");
                                showInfo();
                            }
                            else
                            {
                                MessageBox.Show("Admin Kimliğiyle eşleşen kayıt bulunamadı");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Cannot delete data. Error: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa h = new Anasayfa();
            h.Show();
            this.Hide();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            showInfo(); 
        }

       

        //Selected Columns
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedName = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedExperience = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedPassword = listView1.SelectedItems[0].SubItems[3].Text;

                
                DocIdtxt.Text = selectedId;
                DocNametxt.Text = selectedName;
                DocExptxt.Text = selectedExperience;
                Passwordtxt.Text = selectedPassword;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
