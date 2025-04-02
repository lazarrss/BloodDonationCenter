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

namespace WindowsFormsApp1.formeDoktor
{
    public partial class dodajPacijenta : Form
    {
        string constringdp = Form1.conString;
        string Lozinka = Form1.lozinka;
        string Korisnicko = Form1.korisnickoIme;
        public dodajPacijenta()
        {
            InitializeComponent();
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

        private void tekst6__TextChanged(object sender, EventArgs e)
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
            string email = tekst9.Texts;
            string lozinka = tekst10.Texts;
            string mesto = tekst6.Texts;

            //MessageBox.Show(ime+prezime+datumR+krvnaGrupa+pol+jmbg+brojTelefona+email+lozinka+lozinkaConfirm+mesto+razlikaKonacno);


            if (ime != "" && prezime != "" && krvnaGrupa != "" && pol != ""
                && jmbg != "" && email != "" && lozinka != "" && mesto != "")
            {
                try
                {
                    using (SqlConnection konekcija = new SqlConnection(constringdp))
                    {
                        konekcija.Open();
                        string comString = "insert into Akceptori values ('"+jmbg+"','"+ime+"','"+prezime+"','"+datumR+"','"+krvnaGrupa+"','"+mesto+"',(select id_bolnice from doktori where email='"+Korisnicko+"' and lozinka='"+Lozinka+"'),(select jmbg from doktori where email='"+Korisnicko+"' and lozinka='"+Lozinka+"'),GETDATE() ,'"+email+"','"+lozinka+"')";
                        SqlCommand komanda = new SqlCommand(comString, konekcija);
                        komanda.ExecuteNonQuery();
                        MessageBox.Show("Uspesno");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("nece ");
            Ocisti();
        }

        public void Ocisti()
        {
            tekst1.Texts = "";
            tekst2.Texts = "";
            tekst5.Texts = "";
            tekst6.Texts = "";
            tekst9.Texts = "";
            tekst10.Texts = "";
            kalendar1.Value = DateTime.Now;
            ObojiKrvneGrupe();
            dugme10.BackColor = Color.FromArgb(163, 0, 21);
            dugme11.BackColor = Color.FromArgb(163, 0, 21);
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
            dugme10.BackColor = Color.FromArgb(104, 0, 13);
            dugme11.BackColor = Color.FromArgb(163, 0, 21);
        }

        private void dugme11_Click(object sender, EventArgs e)
        {
            dugme11.BackColor = Color.FromArgb(104, 0, 13);
            dugme10.BackColor = Color.FromArgb(163, 0, 21);
        }
    }
}
