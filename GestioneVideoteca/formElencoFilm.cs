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
    public partial class formElencoFilm : Form
    {
        // inziailizzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public formElencoFilm()
        {
            InitializeComponent();
        }

        // funzione che ritorna l'elenco dei film 
        public DataTable ElencoFilm()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select idFilm, nomeFilm, nomeGenere as Genere from Genere, Film where Film.idGenere = Genere.idGenere AND Film.numeroCopie>0 AND Film.disponibile=1", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void formElencoFilm_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                dgvElencoFilm.DataSource = ElencoFilm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }
    }
}
