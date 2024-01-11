namespace Login
{
    partial class Kitaplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagnosisIDtxt = new System.Windows.Forms.TextBox();
            this.Symptomstxt = new System.Windows.Forms.TextBox();
            this.Diagnosistxt = new System.Windows.Forms.TextBox();
            this.Medicinestxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 149);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1479, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 36);
            this.label9.TabIndex = 53;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(596, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "KÜTÜPHANE";
            // 
            // DiagnosisIDtxt
            // 
            this.DiagnosisIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DiagnosisIDtxt.Location = new System.Drawing.Point(69, 288);
            this.DiagnosisIDtxt.Multiline = true;
            this.DiagnosisIDtxt.Name = "DiagnosisIDtxt";
            this.DiagnosisIDtxt.Size = new System.Drawing.Size(178, 30);
            this.DiagnosisIDtxt.TabIndex = 6;
            this.DiagnosisIDtxt.Text = "Kitap ID";
            this.DiagnosisIDtxt.TextChanged += new System.EventHandler(this.DiagnosisIDtxt_TextChanged);
            // 
            // Symptomstxt
            // 
            this.Symptomstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Symptomstxt.Location = new System.Drawing.Point(291, 288);
            this.Symptomstxt.Multiline = true;
            this.Symptomstxt.Name = "Symptomstxt";
            this.Symptomstxt.Size = new System.Drawing.Size(178, 30);
            this.Symptomstxt.TabIndex = 9;
            this.Symptomstxt.Text = "Kitap Türü";
            this.Symptomstxt.TextChanged += new System.EventHandler(this.Symptomstxt_TextChanged);
            // 
            // Diagnosistxt
            // 
            this.Diagnosistxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Diagnosistxt.Location = new System.Drawing.Point(69, 379);
            this.Diagnosistxt.Multiline = true;
            this.Diagnosistxt.Name = "Diagnosistxt";
            this.Diagnosistxt.Size = new System.Drawing.Size(178, 30);
            this.Diagnosistxt.TabIndex = 10;
            this.Diagnosistxt.Text = "Kitap Adı";
            // 
            // Medicinestxt
            // 
            this.Medicinestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Medicinestxt.Location = new System.Drawing.Point(291, 379);
            this.Medicinestxt.Multiline = true;
            this.Medicinestxt.Name = "Medicinestxt";
            this.Medicinestxt.Size = new System.Drawing.Size(178, 30);
            this.Medicinestxt.TabIndex = 11;
            this.Medicinestxt.Text = "Kitap Yazarı";
            this.Medicinestxt.TextChanged += new System.EventHandler(this.Medicinestxt_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(69, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(291, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(291, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Image = global::Login.Properties.Resources.logout_rounded_left_50px1;
            this.button4.Location = new System.Drawing.Point(69, 543);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookID,
            this.bookType,
            this.bookName,
            this.bookAuthor});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(522, 288);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(928, 404);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // bookID
            // 
            this.bookID.Text = "Kitap ID";
            this.bookID.Width = 82;
            // 
            // bookType
            // 
            this.bookType.Text = "Kitap Türü";
            this.bookType.Width = 228;
            // 
            // bookName
            // 
            this.bookName.Text = "Kitap Adı";
            this.bookName.Width = 244;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Text = "Kitap Yazarı";
            this.bookAuthor.Width = 264;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(186, 629);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 63);
            this.button5.TabIndex = 40;
            this.button5.Text = "En Çok Okunan Kitaplar\r\n";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1516, 938);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Medicinestxt);
            this.Controls.Add(this.Diagnosistxt);
            this.Controls.Add(this.Symptomstxt);
            this.Controls.Add(this.DiagnosisIDtxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiagnosisIDtxt;
        private System.Windows.Forms.TextBox Symptomstxt;
        private System.Windows.Forms.TextBox Diagnosistxt;
        private System.Windows.Forms.TextBox Medicinestxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader bookID;
        private System.Windows.Forms.ColumnHeader bookType;
        private System.Windows.Forms.ColumnHeader bookName;
        private System.Windows.Forms.ColumnHeader bookAuthor;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
    }
}