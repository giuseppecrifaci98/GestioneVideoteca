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
    public partial class formGestioneGenere : Form
    {
        // inizializzo delle variabili 
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int idGenere = 0;

        public formGestioneGenere()
        {
            InitializeComponent();
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

        private void formGestioneGenere_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                cmbGestioneGenereElencoGeneri.DataSource = ElencoGeneri();
                cmbGestioneGenereElencoGeneri.DisplayMember = "nomeGenere";
                cmbGestioneGenereElencoGeneri.ValueMember = "nomeGenere";
                chkCreate.Checked = false;
                chkDelete.Checked = false;
                chkUpdate.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formGestioneGenere_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void cmbGestioneGenereElencoGeneri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // estraggo il numero del film in base al film selezionato dalla combobox
                string nomeGenere = cmbGestioneGenereElencoGeneri.Text;
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

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                txtGestioneGenereModificaGenere.ReadOnly = true;
                txtGestioneGenereNuovoGenere.ReadOnly = true;
            }
            else
            {
                txtGestioneGenereModificaGenere.ReadOnly = false;
                txtGestioneGenereNuovoGenere.ReadOnly = false;
            }
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked)
                txtGestioneGenereNuovoGenere.ReadOnly = true;
            else
                txtGestioneGenereNuovoGenere.ReadOnly = false;
        }

        private void btnGestioneGenere_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkDelete.Checked == true)
                {    
                    cmd = new SqlCommand("DELETE Genere FROM Genere WHERE Genere.idGenere=@id", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idGenere;
                    int x = cmd.ExecuteNonQuery();
                    MessageBox.Show("Genere rimosso correttamente");
                    if (ElencoGeneri().Rows.Count > 0)
                    {
                        cmbGestioneGenereElencoGeneri.DataSource = ElencoGeneri();
                        cmbGestioneGenereElencoGeneri.DisplayMember = "nomeGenere";
                        cmbGestioneGenereElencoGeneri.ValueMember = "nomeGenere";
                    }
                    else { MessageBox.Show("Non ci sono generi da caricare"); }
                }

                if (chkUpdate.Checked == true)
                {  
                    cmd = new SqlCommand("Update Genere SET nomeGenere=@nomeGenere FROM Genere WHERE Genere.idGenere=@id", connection);
                    cmd.Connection = connection; 
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@nomeGenere", SqlDbType.VarChar,255).Value = txtGestioneGenereModificaGenere.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idGenere;
                    int x = cmd.ExecuteNonQuery();
                    MessageBox.Show("Genere modificato correttamente");
                    if (ElencoGeneri().Rows.Count > 0)
                    {
                        cmbGestioneGenereElencoGeneri.DataSource = ElencoGeneri();
                        cmbGestioneGenereElencoGeneri.DisplayMember = "nomeGenere";
                        cmbGestioneGenereElencoGeneri.ValueMember = "nomeGenere";
                    }
                    else { MessageBox.Show("Non ci sono generi da caricare"); }
                }

                if (chkCreate.Checked == true) { 
                    cmd = new SqlCommand("SELECT nomeGenere FROM  Genere WHERE Genere.nomeGenere=@nomeGenere", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@nomeGenere", SqlDbType.VarChar, 255).Value = txtGestioneGenereNuovoGenere.Text;
                    int x = cmd.ExecuteNonQuery();
                    DataTable tb = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cmd;
                    adp.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        MessageBox.Show("Il genere che tenti di creare esiste gia");
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO GENERE (nomeGenere) VALUES(@nome)", connection);
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar, 255).Value = txtGestioneGenereNuovoGenere.Text;
                       cmd.ExecuteNonQuery();
                        MessageBox.Show("Genere creato correttamente");
                        if (ElencoGeneri().Rows.Count > 0) {
                            cmbGestioneGenereElencoGeneri.DataSource = ElencoGeneri();
                            cmbGestioneGenereElencoGeneri.DisplayMember = "nomeGenere";
                            cmbGestioneGenereElencoGeneri.ValueMember = "nomeGenere";
                        }
                        else { MessageBox.Show("Non ci sono generi da caricare"); }
                    }
                   
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nella gestione del genere :" + ex.Message);
            }
        }

        private void chkCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreate.Checked)
            {
                txtGestioneGenereNuovoGenere.ReadOnly = false;
                txtGestioneGenereModificaGenere.ReadOnly = true;
            }
            else
            {
                txtGestioneGenereNuovoGenere.ReadOnly = false;
                txtGestioneGenereModificaGenere.ReadOnly = false;
            }
        }

        private void btnGestioneGenereAnnulla_Click(object sender, EventArgs e)
        {
            SvuotaDati(txtGestioneGenereModificaGenere, txtGestioneGenereNuovoGenere, cmbGestioneGenereElencoGeneri, chkCreate, chkDelete, chkUpdate);
        }
    }
}
