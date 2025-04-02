using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int TogMove;
        int Iks;
        int Ipsilon;
        public static string korisnickoIme;
        public static string lozinka;
        public static string conString = @"Data Source=DESKTOP-JFO70PS;Initial Catalog=DonacijaKrvi;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registrujse rg = new Registrujse();
            rg.ShowDialog();
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dugme1_Click(object sender, EventArgs e)
        {
            korisnickoIme = tekst1.Texts.Trim();
            lozinka = tekst2.Texts.Trim();
            try
            {
                using (SqlConnection konekcija = new SqlConnection(conString))
                {
                    konekcija.Open();
                    
                    string comString1 = "select* from doktori where email like '" + korisnickoIme + "' and lozinka='" + lozinka + "'";
                    SqlCommand komanda1 = new SqlCommand(comString1, konekcija);
                    SqlDataReader sdr1 = komanda1.ExecuteReader();
                    if (sdr1.Read())
                    {
                        Doktor doktor = new Doktor();
                        doktor.ShowDialog();
                    }
                    sdr1.Close();
                    string comString2 = "select* from donori where email like '" + korisnickoIme + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda2 = new SqlCommand(comString2, konekcija);
                    SqlDataReader sdr2 = komanda2.ExecuteReader();
                    if (sdr2.Read())
                    {
                        Donor donor = new Donor();
                        donor.ShowDialog();
                    }
                    sdr2.Close();
                    string comString3 = "select* from akceptori where email like '" + korisnickoIme + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda3 = new SqlCommand(comString3, konekcija);
                    SqlDataReader sdr3 = komanda3.ExecuteReader();
                    if (sdr3.Read())
                    {
                        Akceptor akceptor = new Akceptor();
                        akceptor.ShowDialog();
                    }
                    sdr3.Close();
                    tekst1.Texts = "";
                    tekst2.Texts = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            Iks = e.X;
            Ipsilon = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Iks, MousePosition.Y - Ipsilon);
            }
        }

        private void dugme2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
