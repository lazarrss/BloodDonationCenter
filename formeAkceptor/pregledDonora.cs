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

namespace WindowsFormsApp1.formeAkceptor
{
    public partial class pregledDonora : Form
    {
        string constringpd = Form1.conString;
        public pregledDonora()
        {
            InitializeComponent();
            InicijalizujDGV();
        }

        public void InicijalizujDGV()
        {
            try
            {
                using (SqlConnection konekcija = new SqlConnection(constringpd))
                {
                    konekcija.Open();
                    string comString = "select d.ime as 'Ime',d.prezime as 'Prezime',d.datr as 'Datum Rodjenja',d.krvnagrupa as 'Krvna Grupa',d.pol as 'Pol',d.mesto as 'Mesto', a.maxDatum as 'Dao Krv' from donori as d inner join (select dda.jmbgd, max(datumDavanja) as maxDatum from da as dda group by dda.jmbgd) a on d.jmbg = a.jmbgd";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komanda);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                    /*dataGridView1.Columns[0].Width = 133;
                    dataGridView1.Columns[1].Width = 135;
                    dataGridView1.Columns[2].Width = 135;
                    dataGridView1.Columns[3].Width = 135;
                    dataGridView1.Columns[4].Width = 135;*/
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection konekcija = new SqlConnection(constringpd))
                {
                    konekcija.Open();
                    string comString = "select d.ime as 'Ime',d.prezime as 'Prezime',d.datr as 'Datum Rodjenja',d.krvnagrupa as 'Krvna Grupa',d.pol as 'Pol', a.maxDatum as 'Dao Krv' from donori as d inner join(select dda.jmbgd, max(datumDavanja) as maxDatum from da as dda group by dda.jmbgd) a on d.jmbg = a.jmbgd where d.pol like '" + textBox1.Text + "%'";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komanda);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection konekcija = new SqlConnection(constringpd))
                {
                    konekcija.Open();
                    string comString = "select d.ime as 'Ime',d.prezime as 'Prezime',d.datr as 'Datum Rodjenja',d.krvnagrupa as 'Krvna Grupa',d.pol as 'Pol', a.maxDatum as 'Dao Krv' from donori as d inner join(select dda.jmbgd, max(datumDavanja) as maxDatum from da as dda group by dda.jmbgd) a on d.jmbg = a.jmbgd where d.pol like '" + textBox1.Text + "%'";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komanda);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
