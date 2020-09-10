using GestioneVideoteca.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneVideoteca
{
    public partial class formLogin : Form
    {
        // instanzio le variabili pubbliche
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public bool checkEmail;
        public formLogin()
        {
            InitializeComponent();
        }

        // svuoto le caselle di testo
        public void SvuotaDati(TextBox txt1, TextBox txt2)
        {
            txt1.Clear();
            txt2.Clear();
        }

        // funzione che effettua il login
        public bool AccediUtente(Utenti ut)
        {
            bool check;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT email,password FROM utenti WHERE utenti.email=@email AND utenti.password=@password AND utenti.IsAdministrator=0", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = ut.password;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            if (tb.Rows.Count == 1)
               check = true;
             else
             check = false;

            return check;
        }

        // funzione che effettua il login per gli amministratori
        public bool AccediAmministratore(Utenti ut)
        {
            bool check;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT email,password FROM utenti WHERE utenti.email=@email AND utenti.password=@password AND utenti.IsAdministrator=1", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = ut.password;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            if (tb.Rows.Count == 1)
                check = true;
            else
                check = false;

            return check;
        }

        private void btnGoRegistrazione_Click(object sender, EventArgs e)
        {
            formRegistrazione registrazione = new formRegistrazione();
            registrazione.Show();
            this.Hide();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            try
            {
                SvuotaDati(txtEmail,txtPassword);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel annullare i dati dei controlli:" + ex.Message);
            }
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "" && txtPassword.Text != "")
                {
                    if (txtPassword.TextLength > 4 && checkEmail)
                    {
                            Utenti utente = new Utenti();
                            utente.email = txtEmail.Text;
                            utente.password = txtPassword.Text;
                            if (AccediUtente(utente))
                            {
                                MessageBox.Show("Accesso effettuato correttamente");
                                formDashboard dashboard = new formDashboard(utente.email);
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                if (AccediAmministratore(utente))
                                {
                                    MessageBox.Show("Accesso effettuato correttamente come amministratore");
                                    formDashboardAmministratore dashboard = new formDashboardAmministratore(utente.email);
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Email o password non validi", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                        MessageBox.Show("Lunghezza password non valida la password deve essere lunga dai 4 caratteri in poi o email non è del formato corretto");
                        }
                }
                else
                {
                    MessageBox.Show("Campi vuoti");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel effettuare il login:" + ex.Message);
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void lblAccessoSubtitle2_Click(object sender, EventArgs e)
        {
            try
            {
                formRecuperaPassword recPassword = new formRecuperaPassword();
                recPassword.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel apertura del form per recuperare la password:" + ex.Message);
            }
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
