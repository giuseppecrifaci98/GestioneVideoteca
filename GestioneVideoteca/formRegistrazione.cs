using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* inserisco gli using per connettermi al db */
using System.Data.SqlClient;
using GestioneVideoteca.Classi;
using System.Text.RegularExpressions;

namespace GestioneVideoteca
{
    public partial class formRegistrazione : Form
    {
        /* variabili pubbliche che servono per il databasae e per la gestione degli input */
        public string connectionString;
        public SqlConnection connection;
        public SqlCommand cmd;
        public SqlParameter p1;
        public bool checkEmail;

        public formRegistrazione()
        {
            InitializeComponent();
        }

        // inizializzo come primo valore della combobox un valore "Seleziona"
        public void InizializaCampoVuotoComboBox(ComboBox cmb1, ComboBox cmb2)
        {
            cmb1.Items.Add("--Seleziona");
            cmb2.Items.Add("--Seleziona");
        }

        // funzione con tutti gli input che svuota i dati
        public void SvuotaDati(TextBox tcognome, TextBox tNome, TextBox tEmail, TextBox tPassword, TextBox tConfermapassword,ComboBox cCitta, ComboBox cGenere)
        {
            tcognome.Clear();
            tNome.Clear();
            tEmail.Clear();
            tPassword.Clear();
            tConfermapassword.Clear();
            cCitta.SelectedIndex = 0;
            cGenere.SelectedIndex = 0;
        }

        private void formRegistrazione_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionString);
                connection.Open();
                // inizializzo i campi vuoti sulle combobox
                InizializaCampoVuotoComboBox(cmbGenerePreferito, cmbCitta);
                // mostro i campi del genere preferito
                cmbGenerePreferito.DataSource = RitornaGeneri();
                cmbGenerePreferito.ValueMember = "nomeGenere";
                cmbGenerePreferito.DisplayMember = "nomeGenere";
                // mostro i campi delle citta 
                cmbCitta.DataSource = RitornaCitta();
                cmbCitta.ValueMember = "NomeCitta";
                cmbCitta.DisplayMember = "NomeCitta";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        // funzione che ritorna i generi
        public DataTable RitornaGeneri()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM Genere";
            cmd = new SqlCommand(sql,connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // funzione che ritorna le citta
        public DataTable RitornaCitta()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM Citta";
            cmd = new SqlCommand(sql, connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // funzione che ritorna true o false se l'utente e gia registrato
        public bool VerificaEmail(string email)
        {
            bool check;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Utenti WHERE Utenti.emaiL=@email", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = email;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            if (tb.Rows.Count >= 1)
                check = true;
            else
                check = false;

            return check;
        }

        // funzione che inserisco l'utente 
        public bool RegistraUtente(Utenti ut)
        {
            bool check = true;
            cmd = new SqlCommand("INSERT INTO utenti(cognome,nome,email,password,IdCitta,IdGenere, IsAdministrator) VALUES (@cognome,@nome,@email,@password,@idcitta,@idgenere,@isadministrator)", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cognome", SqlDbType.VarChar, 255).Value = ut.cognome;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 255).Value = ut.nome;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = ut.password;
            cmd.Parameters.Add("@idcitta", SqlDbType.VarChar, 255).Value = ut.idCitta;
            cmd.Parameters.Add("@idgenere", SqlDbType.VarChar, 255).Value = ut.idGenere;
            cmd.Parameters.Add("@isadministrator", SqlDbType.VarChar, 255).Value = ut.isAdministrator;
             int x = cmd.ExecuteNonQuery();
            if (x == 1)
                check = true;
            else
                check = false;

            return check;
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            try
            {
                SvuotaDati(txtCognome, txtNome, txtEmail, txtPassword, txtConfermaPassword, cmbCitta, cmbGenerePreferito);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel annullare i dati dei controlli:" + ex.Message);
            }
        }

        private void btnRegisrati_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtCognome.Text !="" && txtNome.Text !="" && txtEmail.Text!="" && txtPassword.Text!=""&& txtConfermaPassword.Text!= "" )
                {
                    if (txtPassword.TextLength > 4 && txtConfermaPassword.TextLength > 4)
                    {
                        if (txtPassword.Text == txtConfermaPassword.Text)
                        {
                            if (checkEmail)
                            {

                                if (!VerificaEmail(txtEmail.Text))
                                {
                                    MessageBox.Show("Email non presente");
                                    // continua con la registrazione
                                    //MessageBox.Show(cmbGenerePreferito.SelectedIndex.ToString());
                                    //MessageBox.Show(cmbGenerePreferito.SelectedValue.ToString());
                                    Utenti utente = new Utenti();
                                    utente.cognome = txtCognome.Text;
                                    utente.nome = txtNome.Text;
                                    utente.email = txtEmail.Text;
                                    utente.password = txtPassword.Text;
                                    utente.idGenere = cmbGenerePreferito.SelectedIndex + 1;
                                    utente.idCitta = cmbCitta.SelectedIndex + 1;
                                    utente.isAdministrator = 0;
                                    if (RegistraUtente(utente))
                                    {
                                        MessageBox.Show("Utente registrato correttamente");
                                        SvuotaDati(txtCognome, txtNome, txtEmail, txtPassword, txtConfermaPassword, cmbCitta, cmbGenerePreferito);
                                        // redirect sul form login
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Email presente");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email non è del formato corretto");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Le due password non coincidono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lunghezza password non valida la password deve essere lunga dai 4 caratteri in poi");
                    }
                  
                }
                else
                {
                    MessageBox.Show("Campi vuoti");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel registrare i dati utente: " + ex.Message);
            }
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void formRegistrazione_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            Regex reg = new Regex(pattern, RegexOptions.None);
            if (reg.IsMatch(Convert.ToString(txtEmail.Text)))
                checkEmail = true;
            else checkEmail = false;
        }
    }
}
