﻿namespace Login
{
    partial class Giriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Nametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Passtxt = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(130, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİSTEME GİRİŞ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(512, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 36);
            this.label9.TabIndex = 56;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(89, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Admin:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.BurlyWood;
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Loginbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Loginbtn.Location = new System.Drawing.Point(218, 305);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(139, 42);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "GİRİŞ";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nametxt
            // 
            // 
            // 
            // 
            this.Nametxt.CustomButton.Image = null;
            this.Nametxt.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.Nametxt.CustomButton.Name = "";
            this.Nametxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Nametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nametxt.CustomButton.TabIndex = 1;
            this.Nametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nametxt.CustomButton.UseSelectable = true;
            this.Nametxt.CustomButton.Visible = false;
            this.Nametxt.Lines = new string[0];
            this.Nametxt.Location = new System.Drawing.Point(194, 186);
            this.Nametxt.MaxLength = 32767;
            this.Nametxt.Multiline = true;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PasswordChar = '\0';
            this.Nametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nametxt.SelectedText = "";
            this.Nametxt.SelectionLength = 0;
            this.Nametxt.SelectionStart = 0;
            this.Nametxt.ShortcutsEnabled = true;
            this.Nametxt.Size = new System.Drawing.Size(194, 32);
            this.Nametxt.TabIndex = 12;
            this.Nametxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nametxt.UseSelectable = true;
            this.Nametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // Passtxt
            // 
            // 
            // 
            // 
            this.Passtxt.CustomButton.Image = null;
            this.Passtxt.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Passtxt.CustomButton.Name = "";
            this.Passtxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Passtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Passtxt.CustomButton.TabIndex = 1;
            this.Passtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passtxt.CustomButton.UseSelectable = true;
            this.Passtxt.CustomButton.Visible = false;
            this.Passtxt.Lines = new string[0];
            this.Passtxt.Location = new System.Drawing.Point(194, 252);
            this.Passtxt.MaxLength = 32767;
            this.Passtxt.Multiline = true;
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '*';
            this.Passtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passtxt.SelectedText = "";
            this.Passtxt.SelectionLength = 0;
            this.Passtxt.SelectionStart = 0;
            this.Passtxt.ShortcutsEnabled = true;
            this.Passtxt.Size = new System.Drawing.Size(194, 29);
            this.Passtxt.TabIndex = 14;
            this.Passtxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passtxt.UseSelectable = true;
            this.Passtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Passtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 480);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Loginbtn;
        private MetroFramework.Controls.MetroTextBox Nametxt;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Controls.MetroTextBox Passtxt;
        private System.Windows.Forms.Label label9;
    }
}

