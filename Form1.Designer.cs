﻿namespace HAVA_DURMU_V2
{
    partial class Form1
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
            this.TB1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.L1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.L2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PB1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.L3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.BorderColor = System.Drawing.Color.Black;
            this.TB1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB1.DefaultText = "";
            this.TB1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB1.ForeColor = System.Drawing.Color.Black;
            this.TB1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB1.Location = new System.Drawing.Point(28, 5);
            this.TB1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TB1.Name = "TB1";
            this.TB1.PasswordChar = '\0';
            this.TB1.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB1.PlaceholderText = "";
            this.TB1.SelectedText = "";
            this.TB1.Size = new System.Drawing.Size(269, 61);
            this.TB1.TabIndex = 0;
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.Color.Transparent;
            this.L1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.L1.IsSelectionEnabled = false;
            this.L1.Location = new System.Drawing.Point(119, 126);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(96, 61);
            this.L1.TabIndex = 1;
            this.L1.Text = "23°C";
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.Color.Transparent;
            this.L2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.L2.IsSelectionEnabled = false;
            this.L2.Location = new System.Drawing.Point(59, 193);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(205, 61);
            this.L2.TabIndex = 2;
            this.L2.Text = "az bulutlu";
            // 
            // PB1
            // 
            this.PB1.FillColor = System.Drawing.SystemColors.Control;
            this.PB1.ImageRotate = 0F;
            this.PB1.Location = new System.Drawing.Point(135, 322);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(80, 80);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB1.TabIndex = 3;
            this.PB1.TabStop = false;
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.Color.Transparent;
            this.L3.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.L3.IsSelectionEnabled = false;
            this.L3.Location = new System.Drawing.Point(75, 408);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(206, 61);
            this.L3.TabIndex = 4;
            this.L3.Text = "Konya, TR";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(75, 75);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "ARAMA";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 565);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.TB1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAVA DURMU V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TB1;
        private Guna.UI2.WinForms.Guna2HtmlLabel L1;
        private Guna.UI2.WinForms.Guna2HtmlLabel L2;
        private Guna.UI2.WinForms.Guna2PictureBox PB1;
        private Guna.UI2.WinForms.Guna2HtmlLabel L3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

