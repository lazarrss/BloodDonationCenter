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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.formeDonor
{
    public partial class izmeniProfil : Form
    {
        string constringIP = Form1.conString;
        string korisnicko = Form1.korisnickoIme;
        string lozinka = Form1.lozinka;

        public izmeniProfil()
        {
            InitializeComponent();
            Funkcija();
        }


        private void ObojiKrvneGrupe()
        {
            dugme2.BackColor = Color.FromArgb(163, 0, 21);
            dugme3.BackColor = Color.FromArgb(163, 0, 21);
            dugme4.BackColor = Color.FromArgb(163, 0, 21);
            dugme5.BackColor = Color.FromArgb(163, 0, 21);
            dugme6.BackColor = Color.FromArgb(163, 0, 21);
            dugme7.BackColor = Color.FromArgb(163, 0, 21);
            dugme8.BackColor = Color.FromArgb(163, 0, 21);
            dugme9.BackColor = Color.FromArgb(163, 0, 21);

        }

        private string MuskoZensko()
        {
            string pol = "";

            if (dugme10.BackColor == Color.FromArgb(104, 0, 13))
                pol = "musko";
            else pol = "zensko";

            return pol;
        }

        private string KojaJeObojena()
        {
            string obojena = "";

            if (dugme2.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme2.Text;
            else if (dugme3.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme3.Text;
            else if (dugme4.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme4.Text;
            else if (dugme5.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme5.Text;
            else if (dugme6.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme6.Text;
            else if (dugme7.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme7.Text;
            else if (dugme8.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme8.Text;
            else if (dugme9.BackColor == Color.FromArgb(104, 0, 13))
                obojena = dugme9.Text;

            return obojena;
        }

        public string krvnaGrupa = "";
        public string pol = "";

        public void Funkcija()
        {
            try
            {
                using (SqlConnection konekcija = new SqlConnection(constringIP))
                {
                    konekcija.Open();
                    string comString = "select ime, prezime, datr, krvnagrupa, jmbg, mesto, brojtelefona, pol from donori where email='" + korisnicko + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataReader sdr = komanda.ExecuteReader();
                    if (sdr.Read())
                    {
                        tekst1.Texts = sdr[0].ToString().Trim();
                        tekst2.Texts = sdr[1].ToString().Trim();
                        tekst3.Texts = sdr[4].ToString().Trim();
                        tekst4.Texts = sdr[5].ToString().Trim();
                        tekst5.Texts = sdr[6].ToString().Trim();
                        kalendar1.Value = DateTime.Parse(sdr[2].ToString().Trim());
                        krvnaGrupa = sdr[3].ToString().Trim();
                        pol = sdr[7].ToString().Trim();
                    }
                }
                if (pol.Equals("zensko"))
                    dugme11.BackColor = Color.FromArgb(104, 0, 13);
                else dugme10.BackColor = Color.FromArgb(104, 0, 13);
                if (krvnaGrupa.Equals("AB+"))
                {
                    ObojiKrvneGrupe();
                    dugme2.BackColor = Color.FromArgb(104, 0, 13);
                }
                else if (krvnaGrupa.Equals("AB-"))
                {
                    ObojiKrvneGrupe();
                    dugme3.BackColor = Color.FromArgb(104, 0, 13);
                }
                else if (krvnaGrupa.Equals("A+"))
                {
                    ObojiKrvneGrupe();
                    dugme4.BackColor = Color.FromArgb(104, 0, 13);
                }
                else if (krvnaGrupa.Equals("A-"))
                {
                    ObojiKrvneGrupe();
                    dugme5.BackColor = Color.FromArgb(104, 0, 13);
                }
                else if (krvnaGrupa.Equals("B+"))
                {
                    ObojiKrvneGrupe();
                    dugme6.BackColor = Color.FromArgb(104, 0, 13);
                }
                else if (krvnaGrupa.Equals("B-"))
                {
                    ObojiKrvneGrupe();
                    dugme7.BackColor = Color.FromArgb(104, 0, 13);
                }
                else if (krvnaGrupa.Equals("0+"))
                {
                    ObojiKrvneGrupe();
                    dugme8.BackColor = Color.FromArgb(104, 0, 13);
                }
                else
                {
                    ObojiKrvneGrupe();
                    dugme9.BackColor = Color.FromArgb(104, 0, 13);
                }
            
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dugme1_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection konekcija = new SqlConnection(constringIP))
                {
                    konekcija.Open();
                    string kv = KojaJeObojena();
                    string m = MuskoZensko();
                    string comstring = "update donori SET ime = '" + tekst1.Texts + "', prezime = '" + tekst2.Texts + "', datr = '" + kalendar1.Value + "', krvnagrupa = '" + kv + "', jmbg = '" + tekst3.Texts + "', mesto = '" + tekst4.Texts + "', brojtelefona = '" + tekst5.Texts + "', pol = '" + m + "' where lozinka = '"+lozinka+"' and email = '"+korisnicko+"'";
                    SqlCommand komanda = new SqlCommand(comstring, konekcija);
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Uspesno izmenjen profil");
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dugme12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dugme13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dugme2_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme2.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme3_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme3.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme4_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme4.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme5_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme5.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme6_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme6.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme7_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme7.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme8_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme8.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme9_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme9.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme10_Click(object sender, EventArgs e)
        {
            dugme11.BackColor = Color.FromArgb(163, 0, 21);
            dugme10.BackColor = Color.FromArgb(104, 0, 13);
        }

        private void dugme11_Click(object sender, EventArgs e)
        {
            dugme10.BackColor = Color.FromArgb(163, 0, 21);
            dugme11.BackColor = Color.FromArgb(104, 0, 13);
        }
    }
}
