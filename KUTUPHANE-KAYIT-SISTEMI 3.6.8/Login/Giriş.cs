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
    public partial class Giriş : Form
    {

        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\kutuphane.accdb";
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text == "" || Passtxt.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz");
            }
            else
            {
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT adminPass FROM admin WHERE adminName=@adminName";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@adminName", Nametxt.Text);

                     
                        object hashedPassword = cmd.ExecuteScalar();

                        if (hashedPassword != null)
                        {
                
                            string enteredPasswordHash = ComputeHash(Passtxt.Text);

                            if (enteredPasswordHash == hashedPassword.ToString())
                            {
                                MessageBox.Show("Giriş Başarılı");

                                Anasayfa h = new Anasayfa();
                                h.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                            con.Close();
                        }
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



        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Passtxt.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
