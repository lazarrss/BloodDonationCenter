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
using WindowsFormsApp1.formeAkceptor;

namespace WindowsFormsApp1
{
    public partial class Akceptor : Form
    {
        string constringA = Form1.conString;
        public Akceptor()
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
                using (SqlConnection konekcija = new SqlConnection(constringA))
                {
                    konekcija.Open();
                    string comString = "select ime, prezime from akceptori where email='" + email + "' and lozinka = '" + lozinka + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new nalog());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Informacije());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new pregledDonora());
        }
    }
}
