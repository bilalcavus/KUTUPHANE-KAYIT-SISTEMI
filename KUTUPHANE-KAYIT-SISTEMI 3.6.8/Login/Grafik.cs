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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.Common;

namespace Login
{
    public partial class Grafik : Form
    {
        private readonly string connectionString = $"Provider = Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\kutuphane.accdb";


        public Grafik()
        {
            InitializeComponent();

        }

        //Fetch Information

        private void ShowInfo()
        {
            dataGridView1.Rows.Clear();
            using (var con = new OleDbConnection(connectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand("SELECT personBook FROM kisiler", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                dataGridView1.Rows.Add(dr["personBook"]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database cannot connect. Error:" + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }


        






        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Graphics_Load(object sender, EventArgs e)
        {
            ShowInfo();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();

                OleDbConnection con = new OleDbConnection(connectionString);
                con.Open();
                OleDbCommand AccessCommand = new OleDbCommand();
                AccessCommand.Connection = con;
                AccessCommand.CommandText = ("SELECT personBook, COUNT(*) AS KitapSayisi FROM kisiler GROUP BY personBook");
                OleDbDataReader read = AccessCommand.ExecuteReader();

                // Define colour palette
                chart1.Palette = ChartColorPalette.BrightPastel;

                while (read.Read())
                {
                    string PersonBook = read["personBook"].ToString();
                    int diseaseCount = Convert.ToInt32(read["KitapSayisi"]);

                    // Create Column series
                    Series series = new Series(PersonBook);
                    series.ChartType = SeriesChartType.Column;

                    // Set a unique color for each series
                    series.Points.AddXY(PersonBook, diseaseCount);



                    // Insert chart series
                    chart1.Series.Add(series);

                    chart1.ChartAreas[0].AxisX.Title = "En çok alınan kitaplar";

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Anasayfa h = new Anasayfa();
            h.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
