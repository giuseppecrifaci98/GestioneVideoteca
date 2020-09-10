using GestioneVideoteca.Classi;
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
    public partial class formDashboard : Form
    {
        // inizialo la variabile che viene passata dal altro form
        private string _username;
        // inizializzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public string generePrefeito;
        public formDashboard(string username)
        {
            InitializeComponent();
            this._username = username;
            lblAccessoTitle.Text = "";
            lblGenerePreferito.Text = "";
        }

        // funzione che ritorna il nome del genere preferito del utente
        public string GenerePreferitoUtente(Utenti ut)
        {
            string genere;
             DataTable tb = new DataTable();
            cmd = new SqlCommand("select Genere.nomeGenere from Utenti, Genere  where Utenti.email = @email and Utenti.IdGenere = Genere.idGenere", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            genere = tb.Rows[0][0].ToString();
            return genere;
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                Utenti utente = new Utenti();
                utente.email = this._username;
                generePrefeito = GenerePreferitoUtente(utente);
                lblAccessoTitle.Text = "Benvenuto, " + this._username;
                lblGenerePreferito.Text = "Il genere da te preferito è: " + generePrefeito;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void btnFilmConsigliati_Click(object sender, EventArgs e)
        {
            formFilmConsigliati formFilmConsigliati = new formFilmConsigliati(this._username, generePrefeito);
            formFilmConsigliati.Show();
        }

        private void btnElencoFilm_Click(object sender, EventArgs e)
        {
            formElencoFilm elencoFilm = new formElencoFilm();
            elencoFilm.Show();
        }

        private void btnPrenotaFilm_Click(object sender, EventArgs e)
        {
            formPrenotaFilm prenotaFilm = new formPrenotaFilm(this._username, generePrefeito);
            prenotaFilm.Show();
        }

        private void btnGestionePrestiti_Click(object sender, EventArgs e)
        {
            formVisualizzaPrenotazioniUtente visualizzaPrestiti = new formVisualizzaPrenotazioniUtente(this._username);
            visualizzaPrestiti.Show();
        }

        private void btnRestituisciFilm_Click(object sender, EventArgs e)
        {
            formRestituisciFilm restFilm = new formRestituisciFilm(this._username, generePrefeito);
            restFilm.Show();
        }
    }
}
