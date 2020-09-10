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
    public partial class formDashboardAmministratore : Form
    {
         // inizialo la variabile che viene passata dal altro form
        private string _username;
        // inizializzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public formDashboardAmministratore(string username)
        {
            InitializeComponent();
            this._username = username;
            lblAccessoAmministratoreTitle.Text = "";
        }

        private void formDashboardAmministratore_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                // scrivo sulla label di benvenuto
                lblAccessoAmministratoreTitle.Text = "Benvenuto " + this._username;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formDashboardAmministratore_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            formRegistrazione reg = new formRegistrazione();
            reg.Show();
        }

        private void btnGoListUsers_Click(object sender, EventArgs e)
        {
            formListaUtenti formListaUteti = new formListaUtenti();
            formListaUteti.Show();
        }

        private void btnManageGenere_Click(object sender, EventArgs e)
        {
            formGestioneGenere gestGenere = new formGestioneGenere();
            gestGenere.Show();
        }

        private void btnViewListFilm_Click(object sender, EventArgs e)
        {
            formElencoFilm elencoFilm = new formElencoFilm();
            elencoFilm.Show();
        }

        private void btnManageFilm_Click(object sender, EventArgs e)
        {
            formGestioneFilm gestFilm = new formGestioneFilm();
            gestFilm.Show();
        }
    }
}
