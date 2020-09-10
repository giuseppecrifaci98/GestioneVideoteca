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

namespace GestioneVideoteca
{
    public partial class formGestioneFilm : Form
    {
        // inizializzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int idFilm = 0;
        public int idGenere = 0;
        public formGestioneFilm()
        {
            InitializeComponent();
        }

        // funzione che svuota i campi
        public void SvuotaDati(TextBox txt1, TextBox txt2, ComboBox cm1, CheckBox ch1, CheckBox ch2, CheckBox ch3)
        {
            txt1.Clear();
            txt2.Clear();
            cm1.SelectedIndex = 0;
            ch1.Checked = false;
            ch2.Checked = false;
            ch3.Checked = false;
        }

        // carico elenco film
        public DataTable ElencoFilm()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM Film WHERE Film.numeroCopie>0";
            cmd = new SqlCommand(sql, connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // carico elenco generi
        public DataTable ElencoGeneri()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM Genere";
            cmd = new SqlCommand(sql, connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void btnGestioneFilmAnnulla_Click(object sender, EventArgs e)
        {
            SvuotaDati(txtGestioneFilmModificaFilm, txtGestioneFilmNuovoFilm, cmbGestioneFilmElencoFilm, chkGestioneFilmCreate, chkGestioneFilmDelete, chkGestioneFilmUpdate);
        }

        private void formGestioneFilm_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                // imposto i film nella combobox
                cmbGestioneFilmElencoFilm.DataSource = ElencoFilm();
                cmbGestioneFilmElencoFilm.DisplayMember = "nomeFilm";
                cmbGestioneFilmElencoFilm.ValueMember = "nomeFilm";
                chkGestioneFilmCreate.Checked = false;
                chkGestioneFilmDelete.Checked = false;
                chkGestioneFilmUpdate.Checked = false;
                cmbGestioneFilmElencoGenere.Enabled = false;
                dtpDataUscita.Enabled = false;
                cmbGestioneFilmElencoGenere.DataSource = ElencoGeneri();
                cmbGestioneFilmElencoGenere.DisplayMember = "nomeGenere";
                cmbGestioneFilmElencoGenere.ValueMember = "nomeGenere";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formGestioneFilm_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void chkGestioneFilmDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestioneFilmDelete.Checked)
            {
                txtGestioneFilmModificaFilm.ReadOnly = true;
                txtGestioneFilmNuovoFilm.ReadOnly = true;
            }
            else
            {
                txtGestioneFilmModificaFilm.ReadOnly = false;
                txtGestioneFilmNuovoFilm.ReadOnly = false;
            }
        }

        private void chkGestioneFilmUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestioneFilmUpdate.Checked)
                txtGestioneFilmNuovoFilm.ReadOnly = true;
            else
                txtGestioneFilmNuovoFilm.ReadOnly = false;
        }

        private void chkGestioneFilmCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGestioneFilmCreate.Checked)
            {
                txtGestioneFilmNuovoFilm.ReadOnly = false;
                txtGestioneFilmModificaFilm.ReadOnly = true;
                cmbGestioneFilmElencoGenere.Enabled = true;
                dtpDataUscita.Enabled = true;
            }
            else
            {
                txtGestioneFilmNuovoFilm.ReadOnly = false;
                txtGestioneFilmModificaFilm.ReadOnly = false;
                cmbGestioneFilmElencoGenere.Enabled = false;
                dtpDataUscita.Enabled = false;
            }
        }

        private void btnGestioneFilm_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkGestioneFilmDelete.Checked == true)
                {
                    cmd = new SqlCommand("DELETE Film FROM Film WHERE Film.idFilm=@id", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idFilm;
                    int x = cmd.ExecuteNonQuery();
                    MessageBox.Show("Film rimosso correttamente");
                    if (ElencoFilm().Rows.Count > 0)
                    {
                        cmbGestioneFilmElencoFilm.DataSource = ElencoFilm();
                        cmbGestioneFilmElencoFilm.DisplayMember = "nomeFilm";
                        cmbGestioneFilmElencoFilm.ValueMember = "nomeFilm";
                    }
                    else { MessageBox.Show("Non ci sono film da caricare"); }
                }

                if (chkGestioneFilmUpdate.Checked == true)
                {
                    cmd = new SqlCommand("Update Film SET nomeFilm=@nomeFilm FROM Film WHERE Film.idFilm=@id", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@nomeFilm", SqlDbType.VarChar, 255).Value = txtGestioneFilmModificaFilm.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idFilm;
                    int x = cmd.ExecuteNonQuery();
                    MessageBox.Show("Film  modificato correttamente");
                    if (ElencoFilm().Rows.Count > 0)
                    {
                        cmbGestioneFilmElencoFilm.DataSource = ElencoFilm();
                        cmbGestioneFilmElencoFilm.DisplayMember = "nomeFilm";
                        cmbGestioneFilmElencoFilm.ValueMember = "nomeFilm";
                    }
                    else { MessageBox.Show("Non ci sono film da caricare"); }
                }

                if (chkGestioneFilmCreate.Checked == true)
                {
                    cmd = new SqlCommand("SELECT nomeFilm FROM  Film WHERE Film.nomeFilm=@nome", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar, 255).Value = txtGestioneFilmNuovoFilm.Text;
                    int x = cmd.ExecuteNonQuery();
                    DataTable tb = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cmd;
                    adp.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        MessageBox.Show("Il film che tenti di creare esiste gia");
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Film (nomeFilm,idGenere,dataUscita) VALUES(@nome,@idGenere,@datauscita)", connection);
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar, 255).Value = txtGestioneFilmNuovoFilm.Text;
                        cmd.Parameters.Add("@idGenere", SqlDbType.Int).Value = idGenere;
                        cmd.Parameters.Add("@datauscita", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpDataUscita.Value.ToShortDateString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Film creato correttamente");
                        if (ElencoFilm().Rows.Count > 0)
                        {
                            cmbGestioneFilmElencoFilm.DataSource = ElencoFilm();
                            cmbGestioneFilmElencoFilm.DisplayMember = "nomeFilm";
                            cmbGestioneFilmElencoFilm.ValueMember = "nomeFilm";
                        }
                        else { MessageBox.Show("Non ci sono film da caricare"); }
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel effettuare il crud sul film:" + " " + ex.Message);
            }
        }

        private void cmbGestioneFilmElencoFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // estraggo il numero del film in base al film selezionato dalla combobox
                string nomeFilm = cmbGestioneFilmElencoFilm.Text;
                cmd = new SqlCommand("SELECT idFilm FROM Film WHERE Film.nomeFilm=@nome", connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 255).Value = nomeFilm;
                int x = cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter adpFilm = new SqlDataAdapter();
                adpFilm.SelectCommand = cmd;
                adpFilm.Fill(td);
                if (td.Rows.Count > 0)
                    idFilm = Convert.ToInt32(td.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel ricalco del codice id del genere:" + ex.Message);
            }
        }

        private void cmbGestioneFilmElencoGenere_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // estraggo il numero del film in base al film selezionato dalla combobox
                string nomeGenere = cmbGestioneFilmElencoGenere.Text;
                cmd = new SqlCommand("SELECT idGenere FROM Genere WHERE Genere.nomeGenere=@nomeGenere", connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@nomeGenere", SqlDbType.VarChar, 255).Value = nomeGenere;
                int x = cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter adpFilm = new SqlDataAdapter();
                adpFilm.SelectCommand = cmd;
                adpFilm.Fill(td);
                if (td.Rows.Count > 0)
                    idGenere = Convert.ToInt32(td.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel ricalco del codice id del genere:" + ex.Message);
            }
        }
    }
}
