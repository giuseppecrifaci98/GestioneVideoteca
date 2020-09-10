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
    public partial class formFilmConsigliati : Form
    {
        // inizialo la variabile che viene passata dal altro form
        private string _username;
        private string _generePreferito;
        public int IdGenerePreferito;
        // inizializzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public formFilmConsigliati(string username,string generePreferito)
        {
        InitializeComponent();
            this._username = username;
            this._generePreferito = generePreferito;
            lblFilmConsigliatiSubtitle.Text = "";
            lblFilmConsigliatiTitle.Text = "";
        }

        // funzione che ritorna l id del genere 
        public int RitornaIdGenere(string genere)
        {
            int x;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select IdGenere from Genere  where Genere.nomeGenere=@nomeGenere", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nomeGenere", SqlDbType.VarChar, 255).Value = genere;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            x = Convert.ToInt32(tb.Rows[0][0].ToString());
            return x;
        }

        // funzione che ritorna i film consigliati
        public DataTable RitornaFilmConsigliati()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select idFilm,nomeFilm,dataUscita,NomeGenere from Film,Genere where film.idGenere=@idGenere and Genere.idGenere=film.idGenere AND Film.numeroCopie>0 AND Film.disponibile=1", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idGenere", SqlDbType.Int).Value = IdGenerePreferito;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void formFilmConsigliati_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                lblFilmConsigliatiTitle.Text = "Benvenuto, " + this._username;
                lblFilmConsigliatiSubtitle.Text = "Il tuo genere preferito è: " + this._generePreferito;
                IdGenerePreferito = RitornaIdGenere(this._generePreferito);
                dgvFilmConsigliati.DataSource = RitornaFilmConsigliati();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }
    }
}
