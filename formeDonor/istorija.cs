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
    public partial class istorija : Form
    {
        string conStringI = Form1.conString;
        string korisncko = Form1.korisnickoIme;
        string lozinka = Form1.lozinka;
        public istorija()
        {
            InitializeComponent();
            InicijalizujDGV();
        }

        public void InicijalizujDGV()
        {
            try
            {
                using (SqlConnection konekcija = new SqlConnection(conStringI))
                {
                    konekcija.Open();
                    string jmbg = "";
                    string comString = "select jmbg from donori where email='" + korisncko + "' and lozinka = '" + lozinka + "'";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataReader sdr = komanda.ExecuteReader();
                    if (sdr.Read())
                    {
                        jmbg = sdr[0].ToString().Trim();
                    }
                    sdr.Close();
                    string comstring2 = "select a.ime as 'Ime akceptora',a.prezime as 'Prezime akceptora',dda.datumDavanja as 'Datum Davanja',dda.kolicinaKrvi as 'Kolicina Krvi',a.id_bolnice as 'Bolnica' from Akceptori as a left join DA as dda on a.jmbg=dda.jmbgA left join Donori as d on dda.jmbgD=d.jmbg where dda.jmbgd='"+jmbg+"'";
                    SqlCommand komanda2 = new SqlCommand(comstring2, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komanda2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 133;
                    dataGridView1.Columns[1].Width = 135;
                    dataGridView1.Columns[2].Width = 135;
                    dataGridView1.Columns[3].Width = 135;
                    dataGridView1.Columns[4].Width = 135;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
