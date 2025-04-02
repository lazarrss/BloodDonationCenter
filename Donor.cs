using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.formeDonor;

namespace WindowsFormsApp1
{
    public partial class Donor : Form
    {
        string constringD = Form1.conString;
        public Donor()
        {
            InitializeComponent();
            Funkcija();
        }

        public void Funkcija()
        {
            string email = Form1.korisnickoIme;
            string lozinka = Form1.lozinka;

            try
            {
                using (SqlConnection konekcija = new SqlConnection(constringD))
                {
                    konekcija.Open();
                    string comString = "select ime, prezime from donori where email='" + email + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataReader sdr = komanda.ExecuteReader();
                    if (sdr.Read())
                    {
                        string ime = sdr[0].ToString().Trim();
                        string prezime = sdr[1].ToString().Trim();
                        label1.Text = ime + " " + prezime;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadform(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new hitno());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new istorija());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new profil());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new info());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
