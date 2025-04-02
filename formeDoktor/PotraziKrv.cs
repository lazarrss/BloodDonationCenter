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
    public partial class PotraziKrv : Form
    {

        string conStringPK = Form1.conString;
        public PotraziKrv()
        {
            InitializeComponent();
            InicijalizujDGV();
            dataGridView2.Hide();
        }

        public void InicijalizujDGV()
        {
            try
            {
                using(SqlConnection konekcija = new SqlConnection(conStringPK))
                {
                    konekcija.Open();
                    string comString = "select ime as 'Ime',prezime as 'Prezime',jmbg as 'JMBG',krvnagrupa as 'Krvna Grupa',datr as 'Datum Rodjenja',mesto as 'Mesto',id_bolnice as 'Bolnica',id_doktora as 'Doktor' from akceptori";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komanda);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dugme1_Click(object sender, EventArgs e)
        {
            int red = dataGridView1.CurrentCell.RowIndex;
            string imeHitno = dataGridView1.Rows[red].Cells[0].Value.ToString();
            string prezimeHitno = dataGridView1.Rows[red].Cells[1].Value.ToString();
            string jmbgHitno = dataGridView1.Rows[red].Cells[2].Value.ToString();
            string krvnaGrupaHitno = dataGridView1.Rows[red].Cells[3].Value.ToString();
            string datRHitno = dataGridView1.Rows[red].Cells[4].Value.ToString();
            string mestoHitno = dataGridView1.Rows[red].Cells[5].Value.ToString();
            string bolnicaHitno = dataGridView1.Rows[red].Cells[6].Value.ToString();
            string doktorHitno = dataGridView1.Rows[red].Cells[7].Value.ToString();
            try
            {
                using(SqlConnection konekcija = new SqlConnection(conStringPK))
                {
                    konekcija.Open();
                    string comstring = "insert into hitno(ime,prezime,jmbg,krvnagrupa,datr,mesto,id_bolnice,id_doktora,datumprijave) values('"+imeHitno+"','"+prezimeHitno+"','"+jmbgHitno+"','"+krvnaGrupaHitno+"','"+datRHitno+"','"+mestoHitno+"','"+bolnicaHitno+"','"+doktorHitno+"', getdate())";
                    SqlCommand komanda = new SqlCommand(comstring, konekcija);
                    komanda.ExecuteNonQuery();
                    MessageBox.Show("Uspesan zahtev.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tekst1__TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection konekcija = new SqlConnection(conStringPK))
                {
                    konekcija.Open();
                    string comString = "select ime as 'Ime',prezime as 'Prezime',jmbg as 'JMBG',krvnagrupa as 'Krvna Grupa',datr as 'Datum Rodjenja',mesto as 'Mesto',id_bolnice as 'Bolnica',id_doktora as 'Doktor' from akceptori where jmbg like '"+tekst1.Texts+"%'";
                    SqlCommand komanda = new SqlCommand(comString, konekcija);
                    SqlDataAdapter sda = new SqlDataAdapter(komanda);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tekst1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection konekcija = new SqlConnection(conStringPK))
                {
                    konekcija.Open();
                    string comString = "select ime as 'Ime',prezime as 'Prezime',jmbg as 'JMBG',krvnagrupa as 'Krvna Grupa',datr as 'Datum Rodjenja',mesto as 'Mesto',id_bolnice as 'Bolnica',id_doktora as 'Doktor' from akceptori where jmbg like '" + textBox1.Text + "%'";
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
