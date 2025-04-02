using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registrujse : Form
    {
        string conStringR = Form1.conString;
        public Registrujse()
        {
            InitializeComponent();
            button1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void dugme1_Click(object sender, EventArgs e)
        {
            string ime = tekst1.Texts;
            string prezime = tekst2.Texts;
            DateTime datumR = kalendar1.Value;
            string krvnaGrupa = KojaJeObojena();
            string pol = MuskoZensko();
            string jmbg = tekst5.Texts;
            string brojTelefona = tekst7.Texts;
            string email = tekst8.Texts;
            string lozinka = tekst9.Texts;
            string lozinkaConfirm = tekst10.Texts;
            string mesto = tekst6.Texts;
            DateTime trenutno = DateTime.Now;
            TimeSpan razlika = trenutno - datumR;
            double razlikaKonacno = razlika.Days / 365;

            //MessageBox.Show(ime+prezime+datumR+krvnaGrupa+pol+jmbg+brojTelefona+email+lozinka+lozinkaConfirm+mesto+razlikaKonacno);

            
                if (lozinka == lozinkaConfirm && razlikaKonacno >= 18 && ime != "" && prezime != "" && krvnaGrupa != "" && pol != ""
                    && jmbg != "" && brojTelefona != "" && email != "" && lozinka != "" && lozinkaConfirm != "" && mesto != "")
                {
                    try
                    {
                        using (SqlConnection konekcija = new SqlConnection(conStringR))
                        {
                            konekcija.Open();
                            string comString = "insert into donori(jmbg,ime,prezime,datr,krvnaGrupa,email,lozinka,brojTelefona," +
                                "pol,brojDavanjaKrvi,ukupnaKolicinaKrvi,mesto) values ('" + jmbg + "','" + ime + "','" + prezime + "'," +
                                "'" + datumR + "', '" + krvnaGrupa + "', '" + email + "','" + lozinka + "','" + brojTelefona + "','" + pol + "',0,0,'" + mesto + "')";
                            SqlCommand komanda = new SqlCommand(comString, konekcija);
                            komanda.ExecuteNonQuery();
                            MessageBox.Show("Uspesna registracija!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("nece ");
           
                this.Close();
        }

        private void Registrujse_Load(object sender, EventArgs e)
        {
            
        }

        private void dugme2_Click(object sender, EventArgs e)
        {
            ObojiKrvneGrupe();
            dugme2.BackColor = Color.FromArgb(104, 0, 13);
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

        private void dugme13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dugme12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
