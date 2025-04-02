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

namespace WindowsFormsApp1.formeDonor
{
    public partial class profil : Form
    {
        string conStringP = Form1.conString;

        public profil()
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
                using (SqlConnection konekcija = new SqlConnection(conStringP))
                {
                    konekcija.Open();
                    string comString = "select ime, prezime, datr, krvnagrupa, pol, jmbg, mesto, brojtelefona, email from donori where email='" + email + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataReader sdr = komanda.ExecuteReader();
                    if (sdr.Read())
                    {
                        label7.Text = sdr[0].ToString().Trim();
                        label9.Text = sdr[1].ToString().Trim();
                        label12.Text = sdr[2].ToString().Trim();
                        label13.Text = sdr[3].ToString().Trim();
                        label14.Text = sdr[4].ToString().Trim();
                        label15.Text = sdr[5].ToString().Trim();
                        label16.Text = sdr[6].ToString().Trim();
                        label17.Text = sdr[7].ToString().Trim();
                        label18.Text = sdr[8].ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dugme1_Click(object sender, EventArgs e)
        {
            izmeniProfil ip = new izmeniProfil();
            ip.ShowDialog();
        }
    }
}
