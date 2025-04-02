using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.formeDonor
{
    public partial class hitno : Form
    {
        string constring = Form1.conString;
        string korisnicko = Form1.korisnickoIme;
        string lozinka = Form1.lozinka;
        public hitno()
        {
            InitializeComponent();
            InicijalizujDugme1();
            InicijalizujDugme2();
        }

        public void InicijalizujDugme1()
        {
            try
            {
                using(SqlConnection konekcija = new SqlConnection(constring))
                {
                    konekcija.Open();
                    string jmbg = "";
                    string comstring1 = "select jmbg from donori where email = '" + korisnicko + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda = new SqlCommand(comstring1, konekcija);
                    SqlDataReader sdr1 = komanda.ExecuteReader();
                    if(sdr1.Read())
                    {
                        jmbg = sdr1[0].ToString().Trim();
                    }
                    sdr1.Close();
                    string comstring2 = "select count(jmbgd) from da where jmbgd = '" + jmbg + "'";
                    SqlCommand komanda2 = new SqlCommand(comstring2, konekcija);
                    SqlDataReader sdr2 = komanda2.ExecuteReader();
                    if(sdr2.Read())
                    {
                        dugme2.Text = sdr2[0].ToString().Trim();
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void InicijalizujDugme2()
        {
            try
            {
                using (SqlConnection konekcija = new SqlConnection(constring))
                {
                    konekcija.Open();
                    string jmbg = "";
                    string comstring1 = "select jmbg from donori where email = '" + korisnicko + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda = new SqlCommand(comstring1, konekcija);
                    SqlDataReader sdr1 = komanda.ExecuteReader();
                    if (sdr1.Read())
                    {
                        jmbg = sdr1[0].ToString().Trim();
                    }
                    sdr1.Close();
                    string comstring2 = "select sum(kolicinakrvi) from da where jmbgd = '" + jmbg + "'";
                    SqlCommand komanda2 = new SqlCommand(comstring2, konekcija);
                    SqlDataReader sdr2 = komanda2.ExecuteReader();
                    if (sdr2.Read())
                    {
                        dugme3.Text = sdr2[0].ToString().Trim() + "ml";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dugme1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (hitniZahtevi uu = new hitniZahtevi())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .00d;
                    formBackground.BackColor = Color.Black;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void hitno_Load(object sender, EventArgs e)
        {
        }

        private void dugme2_MouseHover(object sender, EventArgs e)
        {
            dugme2.BackColor = Color.FromArgb(255, 255, 250);
        }

        private void dugme3_Click(object sender, EventArgs e)
        {
            dugme3.BackColor = Color.FromArgb(255, 255, 250);
        }


        /*private void timer1_Tick(object sender, EventArgs e)
        {
            if (intImgNum < 4)
                pictureBox1.Image = imageList1.Images[intImgNum];
            else intImgNum = 0;
        }*/
    }
}
