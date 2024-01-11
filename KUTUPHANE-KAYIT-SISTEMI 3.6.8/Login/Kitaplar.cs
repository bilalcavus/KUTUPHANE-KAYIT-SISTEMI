using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;
using System.Xml.Linq;

namespace Login
{

    public partial class Kitaplar : Form
    {
        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\kutuphane.accdb";
        public Kitaplar()
        {
            InitializeComponent();
        }



        //Show Data

        private void showDiagInfo()
        {
            listView1.Items.Clear();
            using(var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using(var cmd = new OleDbCommand("SELECT * FROM kitaplar",con))
                {
                    using(var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while(dr.Read())
                            {
                                ListViewItem addNew = new ListViewItem();
                                addNew.Text = dr["bookID"].ToString();
                                addNew.SubItems.Add(dr["bookType"].ToString());
                                addNew.SubItems.Add(dr["bookName"].ToString());
                                addNew.SubItems.Add(dr["bookAuthor"].ToString());

                                listView1.Items.Add(addNew);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Listeye veri yüklenirken hata oluştu:" + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa h = new Anasayfa();
            h.Show();
            this.Hide();
        }

        //Inserting Data
        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("INSERT INTO kitaplar(bookID,bookType,bookName,bookAuthor) VALUES(@bookID,@bookType,@bookName,@bookAuthor)", con))
                {
                    try
                    {
                        string DIAG_ID = DiagnosisIDtxt.Text;
                        string SYMPTOMS = Symptomstxt.Text;
                        string DIAGNOSIS = Diagnosistxt.Text;
                        string MEDICINES = Medicinestxt.Text;

                        cmd.Parameters.AddWithValue("@bookID", DIAG_ID);
                        cmd.Parameters.AddWithValue("@bookType", SYMPTOMS);
                        cmd.Parameters.AddWithValue("@bookName", DIAGNOSIS);
                        cmd.Parameters.AddWithValue("@bookAuthor", MEDICINES);

                        cmd.ExecuteNonQuery();

                        ListViewItem newItem = new ListViewItem(DIAG_ID);
                        newItem.SubItems.Add(SYMPTOMS);
                        newItem.SubItems.Add(DIAGNOSIS);
                        newItem.SubItems.Add(MEDICINES);


                        MessageBox.Show("Kitap Başarıyla Eklendi.");

                        showDiagInfo();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Veri Eklenemedi: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }

        // Updating Data
        private void button2_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("UPDATE kitaplar SET bookType=?, bookName=?, bookAuthor=? WHERE bookID=?", con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@bookType", Symptomstxt.Text);
                        cmd.Parameters.AddWithValue("@bookName", Diagnosistxt.Text);
                        cmd.Parameters.AddWithValue("@bookAuthor", Medicinestxt.Text);
                        cmd.Parameters.AddWithValue("@bookID", DiagnosisIDtxt.Text);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Kitap Başarıyla Güncellendi");

                            showDiagInfo();
                        }
                        else
                        {
                            MessageBox.Show("Kayıtlı Kitap Bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Veri Güncellenemiyor: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }



        //Deleting Data
        private void button3_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();

                using (var cmd = new OleDbCommand("DELETE FROM kitaplar WHERE bookID=@bookID", con))
                {

                    try
                    {
                        cmd.Parameters.AddWithValue("@bookID", DiagnosisIDtxt.Text);
                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Kitap Başarıyla Silindi.");
                            showDiagInfo();
                        }
                        else
                        {
                            MessageBox.Show("Kayıtlı Kitap Bulunamadı");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Silinemedi: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }



        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
           
            showDiagInfo();
        }

        private void PatIdbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedId = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedName = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedType = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedAuthor = listView1.SelectedItems[0].SubItems[3].Text;

                
                DiagnosisIDtxt.Text = selectedId;
                Diagnosistxt.Text = selectedName;
                Symptomstxt.Text = selectedType;
                Medicinestxt.Text = selectedAuthor;
            }
        }

       

       
        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void diagnosisSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Diagnosislbl_Click(object sender, EventArgs e)
        {

        }

        private void DiagnosisIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Symptomslbl_Click(object sender, EventArgs e)
        {

        }

        private void PatIdbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Patientlbl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Grafik g = new Grafik();
            g.Show();
            this.Hide();
        }

        private void Medicinestxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Symptomstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
