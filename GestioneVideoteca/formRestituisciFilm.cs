using GestioneVideoteca.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneVideoteca
{
    public partial class formRestituisciFilm : Form
    {
        // implemento due variabili che vengono passate dal form dashboard o amministratore
        public string _username;
        public string _generePreferito;
        // inzializzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int idutente;
        public DateTime dataInizio;
        public DateTime dataFine;
        public int idFilm = 0;
        public int idPrenotazione = 0;
        public formRestituisciFilm(string username,string generePreferito)
        {
            InitializeComponent();
            this._username = username;
            this._generePreferito = generePreferito;
        }


        // funzione che ritorna l'id utente 
        public int RitornaIdUtente(string username)
        {
            int x;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select idUtente from Utenti WHERE Utenti.email=@username", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 255).Value = username;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            x = Convert.ToInt32(tb.Rows[0][0].ToString());
            return x;
        }

        // funzione che carica tutte le prenotazioni attive per quel utente
        public DataTable PrenotazioniAttive()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT idPrenotazione, nomeFilm FROM Prenotazioni, Film WHERE Prenotazioni.idUtente = @idutente AND Prenotazioni.Consegnato = 0 AND Prenotazioni.idFilm = Film.idFilm", connection); ;
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idUtente", SqlDbType.Int).Value = idutente;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // funzione che restituisce il film
        public bool RestituisciFilm(Restituzione rst)
        {
            bool check;
            // aggiorno il campo consegnato sul db prenotazioni
            cmd = new SqlCommand("UPDATE Prenotazioni SET Consegnato=1 WHERE Prenotazioni.idPrenotazione=@idPrenotazione", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idPrenotazione", SqlDbType.Int).Value = rst.idPrenotazione;
            int x= cmd.ExecuteNonQuery();
            if (x == 1)
            {
                // aggiorno i giorni di ritardo 
                if (rst.GiorniRitardo > 0)
                {
                    cmd = new SqlCommand("UPDATE Prenotazioni SET GiorniRitardo=@giorni WHERE Prenotazioni.idFilm=@idFilm", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@giorni", SqlDbType.Int).Value = rst.GiorniRitardo;
                    cmd.Parameters.Add("@idFilm", SqlDbType.Int).Value = rst.idFilm;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Film SET numeroCopie=numeroCopie+1 WHERE Film.idFilm=@idFilm", connection);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@idFilm", SqlDbType.Int).Value = rst.idFilm;
                    cmd.ExecuteNonQuery();
                }
                check = true;
            }
            else check = false;

            return check;
        }

        private void formRestituisciFilm_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                // inizializzo le due caselle di testo
                txtRestituisciFilmUsername.Text = this._username;
                txtRestituisciFilmGenerePreferito.Text = this._generePreferito;
                idutente = RitornaIdUtente(this._username);
                if (PrenotazioniAttive().Rows.Count > 0){
                    cmbRestituisciFilm.DataSource = PrenotazioniAttive();
                    cmbRestituisciFilm.DisplayMember = "nomeFilm";
                    cmbRestituisciFilm.ValueMember = "nomeFilm";
                }else{
                    MessageBox.Show("Non ci sono più prenotazioni attive per questo utente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void btnRestitusciFilmAnnulla_Click(object sender, EventArgs e)
        {
            if (PrenotazioniAttive().Rows.Count > 0)
                cmbRestituisciFilm.SelectedIndex = 0;
        }

        private void btnRestitusciFilm_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT dataInizio, dataFine,idPrenotazione FROM Prenotazioni WHERE Prenotazioni.idFilm=@idFilm AND Prenotazioni.idUtente=@idUtente and Prenotazioni.Consegnato=0", connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idFilm", SqlDbType.Int).Value = idFilm;
                cmd.Parameters.Add("@idUtente", SqlDbType.Int).Value = idutente;
                cmd.ExecuteNonQuery();
                DataTable tb = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                adp.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    dataInizio = Convert.ToDateTime(tb.Rows[0][0].ToString());
                    dataFine = Convert.ToDateTime(tb.Rows[0][1].ToString());
                    idPrenotazione = Convert.ToInt32(tb.Rows[0][2].ToString());
                }
             
                DateTime oggi = DateTime.Now;
                if (oggi > dataFine)
                {
                    TimeSpan difference = dataFine.Date - oggi.Date;
                    int days = (int)difference.TotalDays * (-1);
                    Restituzione rst = new Restituzione();
                    rst.idPrenotazione = idPrenotazione;
                    rst.idUtente = idutente;
                    rst.idFilm = idFilm;
                    rst.GiorniRitardo = days;

                    if (RestituisciFilm(rst))
                    {
                        MessageBox.Show("Film riconsegnato con successo con aggiornamento dei giorni di ritardo");
                        if (PrenotazioniAttive().Rows.Count > 0)
                        {
                            cmbRestituisciFilm.DataSource = PrenotazioniAttive();
                            cmbRestituisciFilm.DisplayMember = "nomeFilm";
                            cmbRestituisciFilm.ValueMember = "nomeFilm";
                            cmbRestituisciFilm.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Non ci sono più prenotazioni attive per questo utente");
                        }
                    }
                    else
                        MessageBox.Show("Film non consegnato con successo");
                }
                else if(oggi<dataFine)
                {
                    Restituzione rst = new Restituzione();
                    rst.idPrenotazione = idPrenotazione;
                    rst.idUtente = idutente;
                    rst.idFilm = idFilm;
                    rst.GiorniRitardo = 0;

                    if (RestituisciFilm(rst))
                    {
                        MessageBox.Show("Film riconsegnato con successo");
                        if (PrenotazioniAttive().Rows.Count > 0)
                        {
                            cmbRestituisciFilm.DataSource = PrenotazioniAttive();
                            cmbRestituisciFilm.DisplayMember = "nomeFilm";
                            cmbRestituisciFilm.ValueMember = "nomeFilm";
                            cmbRestituisciFilm.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Non ci sono più prenotazioni attive per questo utente");
                        }
                    }
                    else
                        MessageBox.Show("Film non consegnato con successo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nella consegna del film: " + ex.Message);
            }
        }

        private void cmbRestituisciFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            try
            {
                // estraggo il numero del film in base al film selezionato dalla combobox
                string nomeFilm = cmbRestituisciFilm.Text;
                cmd = new SqlCommand("SELECT idFilm FROM Film WHERE Film.nomeFilm=@nomeFilm", connection);
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@nomeFilm", SqlDbType.VarChar, 255).Value = nomeFilm;
                int x = cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter adpFilm = new SqlDataAdapter();
                adpFilm.SelectCommand = cmd;
                adpFilm.Fill(td);
                if (td.Rows.Count > 0)
                    idFilm = Convert.ToInt32(td.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel ricalco dei giorni passati dal noleggio:" + ex.Message);
            }
        }
    }
}
