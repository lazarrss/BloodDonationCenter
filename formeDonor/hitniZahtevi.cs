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
    public partial class hitniZahtevi : Form
    {
        string constring = Form1.conString;
        string korisnicko = Form1.korisnickoIme;
        string lozinka = Form1.lozinka;
        public hitniZahtevi()
        {
            InitializeComponent();
            InicijalizujDGV();
        }

        public bool Kompatibilan(string donor, string akceptor)
        {
            bool z = false;
            if (akceptor.Equals("AB+"))
                z = true;
            else if (akceptor.Equals("AB-") && !(donor.Equals("AB+") || donor.Equals("A+") || donor.Equals("B+") || donor.Equals("0+")))
                z = true;
            else if (akceptor.Equals("A+") && !(donor.Equals("AB+") || donor.Equals("AB-") || donor.Equals("B+") || donor.Equals("B-")))
                z = true;
            else if (akceptor.Equals("A-") && !(donor.Equals("AB+") || donor.Equals("AB-") || donor.Equals("B+") || donor.Equals("B-") || donor.Equals("0+")))
                z = true;
            else if (akceptor.Equals("B+") && !(donor.Equals("AB+") || donor.Equals("AB-") || donor.Equals("A+") || donor.Equals("A-")))
                z = true;
            else if (akceptor.Equals("B-") && !(donor.Equals("AB+") || donor.Equals("AB-") || donor.Equals("A+") || donor.Equals("A-") || donor.Equals("0+")))
                z = true;
            else if (akceptor.Equals("0+") && !(donor.Equals("AB+") || donor.Equals("AB-") || donor.Equals("B+") || donor.Equals("B-") || donor.Equals("A+") || donor.Equals("A-")))
                z = true;
            else if (akceptor.Equals("0-") && !(donor.Equals("AB+") || donor.Equals("AB-") || donor.Equals("B+") || donor.Equals("B-") || donor.Equals("A+") || donor.Equals("A-") || donor.Equals("0+")))
                z = true;

                return z;
        }
        
        public void InicijalizujDGV()
        {
            try
            {
                using(SqlConnection konekcija = new SqlConnection(constring))
                {
                    konekcija.Open();
                    string krvnagrupaD = "";
                    string comString1 = "select krvnagrupa from donori where email='" + korisnicko + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda = new SqlCommand(comString1, konekcija);
                    SqlDataReader sdr = komanda.ExecuteReader();
                    if (sdr.Read())
                    {
                        krvnagrupaD = sdr[0].ToString().Trim();
                    }
                    sdr.Close();
                    List<HitniSlucajevi> listaHitnihSlucajeva = new List<HitniSlucajevi>();
                    string comstring = "select mesto,id_bolnice,krvnagrupa,ime,prezime from hitno";
                    SqlCommand komandaHitno = new SqlCommand(comstring,konekcija);
                    SqlDataReader sdr2 = komandaHitno.ExecuteReader();
                    while(sdr2.Read())
                    {
                        listaHitnihSlucajeva.Add(new HitniSlucajevi(sdr2[0].ToString().Trim(), sdr2[1].ToString().Trim(), sdr2[2].ToString().Trim(), sdr2[3].ToString().Trim(), sdr2[4].ToString().Trim()));
                    }

                    List<HitniSlucajevi> nova = new List<HitniSlucajevi>();

                    foreach (HitniSlucajevi hs in listaHitnihSlucajeva)
                    {
                        if(Kompatibilan(krvnagrupaD, hs.krvnaGrupa))
                        {
                            nova.Add(hs);
                        }
                    }
                    dgv1.DataSource = nova;
                }
            }catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dugme12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dugme13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
