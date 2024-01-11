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


namespace Login
{
    public partial class Kişiler : Form
    {
        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\kutuphane.accdb";
        public Kişiler()
        {
            InitializeComponent();
        }
        //Show Data
        private void showPatInfo()
        {
            listView1.Items.Clear();
            using(var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using(var cmd = new  OleDbCommand("SELECT * FROM kisiler", con))
                {
                    using(var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["personID"].ToString();
                                addNew.SubItems.Add(dr["personName"].ToString());
                                addNew.SubItems.Add(dr["personCity"].ToString());
                                addNew.SubItems.Add(dr["personPhone"].ToString());
                                addNew.SubItems.Add(dr["personAge"].ToString());
                                addNew.SubItems.Add(dr["personGender"].ToString());
                                addNew.SubItems.Add(dr["personJob"].ToString());
                                addNew.SubItems.Add(dr["personBook"].ToString());

                                listView1.Items.Add(addNew);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Listeye veri yüklenirken hata oluştu: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }


        // Inserting Data
        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new OleDbCommand("INSERT INTO kisiler(personID,personName,personCity,personPhone,personAge,personGender,personJob,personBook) " +
                    "VALUES(@personID, @personName, @personCity, @personPhone, @personAge, @personGender, @personJob, @personBook)", connection))
                {
                    try
                    {
                        string ID = PatIdtxt.Text;
                        string NAME = PatNametxt.Text;
                        string ADDRESS = Addresstxt.Text;
                        string PHONE = Phonetxt.Text;
                        string AGE = Agetxt.Text;
                        string GENDER = GenderBox.Text;
                        string BLOOD_GROUP = BloodGRPBox.Text;
                        string MAJOR_DISEASE = MjDiseasetxt.Text;

                        cmd.Parameters.AddWithValue("@personID", ID);
                        cmd.Parameters.AddWithValue("@personName", NAME);
                        cmd.Parameters.AddWithValue("@personCity", ADDRESS);
                        cmd.Parameters.AddWithValue("@personPhone", PHONE);
                        cmd.Parameters.AddWithValue("@personAge", AGE);
                        cmd.Parameters.AddWithValue("@personGender", GENDER);
                        cmd.Parameters.AddWithValue("@personJob", BLOOD_GROUP);
                        cmd.Parameters.AddWithValue("@personBook", MAJOR_DISEASE);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kişi Başarıyla Eklendi.");

                        showPatInfo();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Veri Eklenemedi: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        //Updating Data
        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE kisiler SET personName=?, personCity=?, personPhone=?, personAge=?, personGender=?, personJob=?, personBook=? WHERE personID=?", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@personName", PatNametxt.Text);
                        cmd.Parameters.AddWithValue("@personCity", Addresstxt.Text);
                        cmd.Parameters.AddWithValue("@personPhone", Phonetxt.Text);
                        cmd.Parameters.AddWithValue("@personAge", Agetxt.Text);
                        cmd.Parameters.AddWithValue("@personGender", GenderBox.Text);
                        cmd.Parameters.AddWithValue("@personJob", BloodGRPBox.Text);
                        cmd.Parameters.AddWithValue("@personJob", MjDiseasetxt.Text);
                        cmd.Parameters.AddWithValue("@personBook", PatIdtxt.Text);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Kişi Başarıyla Güncellendi.");

                            showPatInfo();
                        }
                        else
                        {
                            MessageBox.Show("ID için eşleşen kayıt bulunamadı");
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Güncellenemedi: " + ex.Message);
                    }
                    finally
                    {
                        con?.Close();
                    }

                }
            }
        }

        //Deleting Data
        private void button4_Click(object sender, EventArgs e)
        {
            if (PatNametxt.Text == "")
            {
                MessageBox.Show("Lütfen ID Giriniz.");
            }
            else
            {
                using (var con = new OleDbConnection(connectionString))
                {
                    con.Open();
                    using (var cmd = new OleDbCommand("DELETE FROM kisiler WHERE personID=@personID", con))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@personID", PatIdtxt.Text);
                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Kişi Başarıyla Silindi");
                                showPatInfo();
                            }
                            else
                            {
                                MessageBox.Show("ID için eşleşen kayıt bulunamadı");
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Veri Silinemedi: " + ex.Message);
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

        //Selected Columns
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedName = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedAddress = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedPhone = listView1.SelectedItems[0].SubItems[3].Text;
                string selectedAge = listView1.SelectedItems[0].SubItems[4].Text;
                string selectedGender = listView1.SelectedItems[0].SubItems[5].Text;
                string selectedBloodGroup = listView1.SelectedItems[0].SubItems[6].Text;
                string selectedMajorDisease = listView1.SelectedItems[0].SubItems[7].Text;

                PatIdtxt.Text = selectedId;
                PatNametxt.Text = selectedName;
                Addresstxt.Text = selectedAddress;
                Phonetxt.Text = selectedPhone;
                Agetxt.Text = selectedAge;
                GenderBox.Text = selectedGender;
                BloodGRPBox.Text = selectedBloodGroup;
                MjDiseasetxt.Text = selectedMajorDisease;
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            showPatInfo();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BloodGRPBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
     
    }
}
