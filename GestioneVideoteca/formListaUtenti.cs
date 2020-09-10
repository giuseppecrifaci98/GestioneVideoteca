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
    public partial class formListaUtenti : Form
    {
        // inizialo le variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public formListaUtenti()
        {
            InitializeComponent();
        }

        // funzione che ritorna tutta la lista degli utenti
        public DataTable ListaUtenti()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT idUtente, cognome, nome, email, nomeCitta, nomeGenere from Utenti, Genere, Citta where Utenti.IdCitta = Citta.IdCitta and Genere.idGenere = Utenti.IdGenere", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        private void formListaUtenti_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                // inserisco nella datagrid i  dati del database per gli utenti
                dgvListaUtenti.DataSource = ListaUtenti();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        // funzione che modifica l utente 
        public bool ModificaUtente(Utenti ut)
        {
            bool check;
            cmd = new SqlCommand("UPDATE Utenti SET cognome=@cognome, nome=@nome, email=@email FROM Utenti WHERE Utenti.idUtente=@id", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cognome", SqlDbType.VarChar, 255).Value = ut.cognome;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 255).Value = ut.nome;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(ut.idUtente);
            int x= cmd.ExecuteNonQuery();
            if (x == 1) check = true; else check = false;
            return check;
        }

        // funzione che elimina l utente
        public bool EliminaUtente(Utenti ut)
        {
            bool check;
            cmd = new SqlCommand("DELETE Utenti FROM Utenti WHERE Utenti.idUtente=@idUtente", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idUtente", SqlDbType.Int).Value = Convert.ToInt32(ut.idUtente);
            int x= cmd.ExecuteNonQuery();
            if (x == 1) check = true; else check = false;
            return check;
        }

        private void formListaUtenti_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void btnGestioneUtenteEliminaUtente_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dgvListaUtenti.CurrentCell.RowIndex);
                txtGestioneUtenteDeleteId.Text = Convert.ToString(dgvListaUtenti.Rows[i].Cells[0].Value);
                if (txtGestioneUtenteDeleteId.Text != "")
                {
                    Utenti ut = new Utenti();
                    ut.idUtente = Convert.ToInt32(txtGestioneUtenteDeleteId.Text);
                    if (EliminaUtente(ut))
                    {
                        MessageBox.Show("Ho eliminato l'utente con l id da te selezionato");
                        dgvListaUtenti.DataSource = ListaUtenti();
                    }
                    else { MessageBox.Show("Errore nella cancellazione del utente"); }
                }
            }
             catch(Exception ex)
            {
                MessageBox.Show("Errore nella cancellazione del utente indicato:" + " " + ex.Message);
            }
        }

        private void btnGestioneUtenteAnnulla_Click(object sender, EventArgs e)
        {
            txtGestioneUtenteDeleteId.Clear();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dgvListaUtenti.CurrentCell.RowIndex);
                txtGestioneUtenteModificaIDUtente.Text = Convert.ToString(dgvListaUtenti.Rows[i].Cells[0].Value);
               if (txtGestioneUtenteModificaCognome.Text != "" && txtGestioneUtenteModificaNome.Text != "" && txtGestioneUtenteModificaEmail.Text != ""){
                    Utenti ut = new Utenti();
                    ut.cognome = txtGestioneUtenteModificaCognome.Text;
                    ut.nome = txtGestioneUtenteModificaNome.Text;
                    ut.email = txtGestioneUtenteModificaEmail.Text;
                    ut.idUtente = Convert.ToInt32(txtGestioneUtenteModificaIDUtente.Text);
                    if (ModificaUtente(ut))
                    {
                        MessageBox.Show("Ho modifica l'utente con l id da te selezionato");
                        dgvListaUtenti.DataSource = ListaUtenti();
                    }
                    else
                    {
                        MessageBox.Show("Errore nella modifica del utente");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel modificare lutente:" + " " + ex.Message);
            }
        }
    }
}
