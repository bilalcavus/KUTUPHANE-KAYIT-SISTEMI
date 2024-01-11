namespace Login
{
    partial class Kişiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kişiler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatIdtxt = new System.Windows.Forms.TextBox();
            this.PatNametxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.MjDiseasetxt = new System.Windows.Forms.TextBox();
            this.Agetxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.BloodGRPBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.personID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.Size = new System.Drawing.Size(1617, 149);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1481, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 36);
            this.label9.TabIndex = 54;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(661, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİŞİ KAYIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatIdtxt
            // 
            this.PatIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatIdtxt.Location = new System.Drawing.Point(36, 146);
            this.PatIdtxt.Multiline = true;
            this.PatIdtxt.Name = "PatIdtxt";
            this.PatIdtxt.Size = new System.Drawing.Size(168, 30);
            this.PatIdtxt.TabIndex = 5;
            this.PatIdtxt.Text = "Kişi ID";
            // 
            // PatNametxt
            // 
            this.PatNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PatNametxt.Location = new System.Drawing.Point(36, 197);
            this.PatNametxt.Multiline = true;
            this.PatNametxt.Name = "PatNametxt";
            this.PatNametxt.Size = new System.Drawing.Size(168, 30);
            this.PatNametxt.TabIndex = 6;
            this.PatNametxt.Text = "Kişi Adı";
            // 
            // Phonetxt
            // 
            this.Phonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Phonetxt.Location = new System.Drawing.Point(36, 303);
            this.Phonetxt.Multiline = true;
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(168, 30);
            this.Phonetxt.TabIndex = 7;
            this.Phonetxt.Text = "Telefon No";
            // 
            // MjDiseasetxt
            // 
            this.MjDiseasetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MjDiseasetxt.Location = new System.Drawing.Point(36, 502);
            this.MjDiseasetxt.Multiline = true;
            this.MjDiseasetxt.Name = "MjDiseasetxt";
            this.MjDiseasetxt.Size = new System.Drawing.Size(168, 30);
            this.MjDiseasetxt.TabIndex = 8;
            this.MjDiseasetxt.Text = "Aldığı Kitap";
            // 
            // Agetxt
            // 
            this.Agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Agetxt.Location = new System.Drawing.Point(36, 355);
            this.Agetxt.Multiline = true;
            this.Agetxt.Name = "Agetxt";
            this.Agetxt.Size = new System.Drawing.Size(168, 30);
            this.Agetxt.TabIndex = 9;
            this.Agetxt.Text = "Yaş";
            // 
            // Addresstxt
            // 
            this.Addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Addresstxt.Location = new System.Drawing.Point(36, 251);
            this.Addresstxt.Multiline = true;
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(168, 30);
            this.Addresstxt.TabIndex = 10;
            this.Addresstxt.Text = "Şehir";
            // 
            // GenderBox
            // 
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.GenderBox.Location = new System.Drawing.Point(36, 406);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(168, 28);
            this.GenderBox.TabIndex = 11;
            this.GenderBox.Text = "Cinsiyet";
            // 
            // BloodGRPBox
            // 
            this.BloodGRPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BloodGRPBox.FormattingEnabled = true;
            this.BloodGRPBox.Items.AddRange(new object[] {
            "Yönetici",
            "Öğretmen",
            "Öğrenci"});
            this.BloodGRPBox.Location = new System.Drawing.Point(36, 454);
            this.BloodGRPBox.Name = "BloodGRPBox";
            this.BloodGRPBox.Size = new System.Drawing.Size(168, 28);
            this.BloodGRPBox.TabIndex = 12;
            this.BloodGRPBox.Text = "Meslek";
            this.BloodGRPBox.SelectedIndexChanged += new System.EventHandler(this.BloodGRPBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(36, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(208, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(208, 627);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 16;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(807, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 42);
            this.label11.TabIndex = 33;
            this.label11.Text = "KİŞİ LİSTESİ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Image = global::Login.Properties.Resources.logout_rounded_left_50px2;
            this.button5.Location = new System.Drawing.Point(36, 627);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 36);
            this.button5.TabIndex = 34;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personID,
            this.personName,
            this.personCity,
            this.personPhone,
            this.personAge,
            this.personGender,
            this.personJob,
            this.personBook});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(366, 251);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1096, 412);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // personID
            // 
            this.personID.Text = "Kişi ID";
            // 
            // personName
            // 
            this.personName.Text = "Kişi Adı";
            this.personName.Width = 211;
            // 
            // personCity
            // 
            this.personCity.Text = "Şehir";
            this.personCity.Width = 265;
            // 
            // personPhone
            // 
            this.personPhone.Text = "Telefon";
            this.personPhone.Width = 193;
            // 
            // personAge
            // 
            this.personAge.Text = "Yaş";
            this.personAge.Width = 66;
            // 
            // personGender
            // 
            this.personGender.Text = "Cinsiyet";
            this.personGender.Width = 79;
            // 
            // personJob
            // 
            this.personJob.Text = "Meslek";
            this.personJob.Width = 96;
            // 
            // personBook
            // 
            this.personBook.Text = "Aldıgı Kitap";
            this.personBook.Width = 136;
            // 
            // Kişiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1617, 795);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BloodGRPBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Agetxt);
            this.Controls.Add(this.MjDiseasetxt);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.PatNametxt);
            this.Controls.Add(this.PatIdtxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kişiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatIdtxt;
        private System.Windows.Forms.TextBox PatNametxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.TextBox MjDiseasetxt;
        private System.Windows.Forms.TextBox Agetxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox BloodGRPBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader personID;
        private System.Windows.Forms.ColumnHeader personName;
        private System.Windows.Forms.ColumnHeader personCity;
        private System.Windows.Forms.ColumnHeader personPhone;
        private System.Windows.Forms.ColumnHeader personAge;
        private System.Windows.Forms.ColumnHeader personGender;
        private System.Windows.Forms.ColumnHeader personJob;
        private System.Windows.Forms.ColumnHeader personBook;
        private System.Windows.Forms.Label label9;
    }
}