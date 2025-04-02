namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tekst2 = new WindowsFormsApp1.Tekst();
            this.tekst1 = new WindowsFormsApp1.Tekst();
            this.dugme1 = new WindowsFormsApp1.sve.Dugme();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dugme2 = new WindowsFormsApp1.sve.Dugme();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisnicko Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(357, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registruj se";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label3_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.loginslika;
            this.pictureBox1.Location = new System.Drawing.Point(232, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tekst2
            // 
            this.tekst2.BackColor = System.Drawing.SystemColors.Window;
            this.tekst2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tekst2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tekst2.BorderRadius = 6;
            this.tekst2.BorderSize = 2;
            this.tekst2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekst2.ForeColor = System.Drawing.Color.DimGray;
            this.tekst2.Location = new System.Drawing.Point(33, 156);
            this.tekst2.Margin = new System.Windows.Forms.Padding(4);
            this.tekst2.Multiline = false;
            this.tekst2.Name = "tekst2";
            this.tekst2.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tekst2.PasswordChar = true;
            this.tekst2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tekst2.PlaceholderText = "";
            this.tekst2.Size = new System.Drawing.Size(161, 29);
            this.tekst2.TabIndex = 9;
            this.tekst2.Texts = "";
            this.tekst2.UnderlinedStyle = true;
            // 
            // tekst1
            // 
            this.tekst1.BackColor = System.Drawing.SystemColors.Window;
            this.tekst1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tekst1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tekst1.BorderRadius = 6;
            this.tekst1.BorderSize = 2;
            this.tekst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekst1.ForeColor = System.Drawing.Color.DimGray;
            this.tekst1.Location = new System.Drawing.Point(33, 82);
            this.tekst1.Margin = new System.Windows.Forms.Padding(4);
            this.tekst1.Multiline = false;
            this.tekst1.Name = "tekst1";
            this.tekst1.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tekst1.PasswordChar = false;
            this.tekst1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tekst1.PlaceholderText = "";
            this.tekst1.Size = new System.Drawing.Size(161, 29);
            this.tekst1.TabIndex = 8;
            this.tekst1.Texts = "";
            this.tekst1.UnderlinedStyle = true;
            // 
            // dugme1
            // 
            this.dugme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.dugme1.FlatAppearance.BorderSize = 0;
            this.dugme1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme1.ForeColor = System.Drawing.Color.White;
            this.dugme1.Location = new System.Drawing.Point(46, 217);
            this.dugme1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dugme1.Name = "dugme1";
            this.dugme1.Size = new System.Drawing.Size(135, 38);
            this.dugme1.TabIndex = 7;
            this.dugme1.Text = "Log in";
            this.dugme1.UseVisualStyleBackColor = false;
            this.dugme1.Click += new System.EventHandler(this.dugme1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(256, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nemaš nalog?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dugme2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 33);
            this.panel1.TabIndex = 14;
            // 
            // dugme2
            // 
            this.dugme2.BackColor = System.Drawing.Color.Transparent;
            this.dugme2.FlatAppearance.BorderSize = 0;
            this.dugme2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme2.ForeColor = System.Drawing.Color.Black;
            this.dugme2.Location = new System.Drawing.Point(420, -1);
            this.dugme2.Name = "dugme2";
            this.dugme2.Size = new System.Drawing.Size(45, 33);
            this.dugme2.TabIndex = 0;
            this.dugme2.Text = "❌";
            this.dugme2.UseVisualStyleBackColor = false;
            this.dugme2.Click += new System.EventHandler(this.dugme2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(465, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tekst2);
            this.Controls.Add(this.tekst1);
            this.Controls.Add(this.dugme1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private sve.Dugme dugme1;
        private Tekst tekst1;
        private Tekst tekst2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private sve.Dugme dugme2;
    }
}

