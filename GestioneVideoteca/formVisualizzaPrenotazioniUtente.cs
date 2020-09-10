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
    public partial class formVisualizzaPrenotazioniUtente : Form
    {
        private string _username;
        // inizializzo delle varaibili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int idutente;
        public formVisualizzaPrenotazioniUtente(string username)
        {
            InitializeComponent();
            this._username = username;
        }

        // funzione che ritorna l id utente
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

        // funzione che ritorna tutti i prestiti attivi del utente
        public DataTable EencoPrenotazioniAttive()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select * from Prenotazioni WHERE  Prenotazioni.dataInizio >= getdate() - 1 AND Prenotazioni.dataFine <= GETDATE() + 7 AND Prenotazioni.idUtente=@idutente", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idutente", SqlDbType.Int).Value = idutente;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void formVisualizzaPrenotazioniUtente_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                // ricevo l'id utente
                idutente = RitornaIdUtente(this._username);
                // inserisco i dati nella tabella
                dgvMostraPrenotazioni.DataSource = EencoPrenotazioniAttive();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }
    }
}
