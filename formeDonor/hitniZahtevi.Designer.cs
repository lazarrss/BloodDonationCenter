namespace WindowsFormsApp1.formeDonor
{
    partial class hitniZahtevi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dugme13 = new WindowsFormsApp1.sve.Dugme();
            this.dugme12 = new WindowsFormsApp1.sve.Dugme();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgv1.Location = new System.Drawing.Point(12, 49);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(776, 389);
            this.dgv1.TabIndex = 1;
            // 
            // dugme13
            // 
            this.dugme13.BackColor = System.Drawing.Color.Transparent;
            this.dugme13.FlatAppearance.BorderSize = 0;
            this.dugme13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme13.ForeColor = System.Drawing.Color.Black;
            this.dugme13.Location = new System.Drawing.Point(704, 0);
            this.dugme13.Name = "dugme13";
            this.dugme13.Size = new System.Drawing.Size(45, 33);
            this.dugme13.TabIndex = 48;
            this.dugme13.Text = "🗕";
            this.dugme13.UseVisualStyleBackColor = false;
            this.dugme13.Click += new System.EventHandler(this.dugme13_Click);
            // 
            // dugme12
            // 
            this.dugme12.BackColor = System.Drawing.Color.Transparent;
            this.dugme12.FlatAppearance.BorderSize = 0;
            this.dugme12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugme12.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugme12.ForeColor = System.Drawing.Color.Black;
            this.dugme12.Location = new System.Drawing.Point(755, 0);
            this.dugme12.Name = "dugme12";
            this.dugme12.Size = new System.Drawing.Size(45, 33);
            this.dugme12.TabIndex = 47;
            this.dugme12.Text = "❌";
            this.dugme12.UseVisualStyleBackColor = false;
            this.dugme12.Click += new System.EventHandler(this.dugme12_Click);
            // 
            // hitniZahtevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dugme13);
            this.Controls.Add(this.dugme12);
            this.Controls.Add(this.dgv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hitniZahtevi";
            this.Text = "hitniZahtevi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private sve.Dugme dugme13;
        private sve.Dugme dugme12;
    }
}