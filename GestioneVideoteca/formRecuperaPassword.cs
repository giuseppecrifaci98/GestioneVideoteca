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
    public partial class formRecuperaPassword : Form
    {
        // inizializzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public bool checkEmail;
        public formRecuperaPassword()
        {
            InitializeComponent();
        }

        private void formRecuperaPassword_Load(object sender, EventArgs e)
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
                MessageBox.Show("Errore nel caricamento :" + ex.Message);
            }
        }

        // funzione che svuota le textbox
        public void SvuotaDati(TextBox txt1, TextBox txt2,TextBox txt3)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }

        // verifica l'email 
        public bool ControlloEmail(Utenti ut)
        {
            bool check = true;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("SELECT * FROM utenti WHERE utenti.email=@email", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
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

        // funzione che permette di cambiare la password
        public bool CambiaPassword(Utenti ut)
        {
            bool check = true;
            cmd = new SqlCommand("UPDATE utenti SET utenti.password=@password WHERE utenti.email=@email", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = ut.password;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = ut.email;
            int x = cmd.ExecuteNonQuery();
            if (x == 1) check = true; else check = false;        
            return check;
        }

        private void btnCambiaPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "" && txtPassword.Text != "" && txtConfermaPassword.Text != "")
                {
                    if (txtPassword.TextLength > 4 && txtConfermaPassword.TextLength > 4)
                    {
                        if (txtPassword.Text == txtConfermaPassword.Text)
                        {
                            if (checkEmail)
                            {
                                Utenti utente = new Utenti();
                                utente.email = txtEmail.Text;
                                utente.password = txtPassword.Text;
                                if (!ControlloEmail(utente))
                                    MessageBox.Show("L'email non è presente nel database", "avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                {
                                    if (CambiaPassword(utente))
                                    {
                                        MessageBox.Show("La password è stata cambiata correttamente", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        formLogin login = new formLogin();
                                        login.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Errore nel cambiare la password", "avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email non è del formato corretto");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Le due password non coincidono", "avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lunghezza password non valida la password deve essere lunga dai 4 caratteri in poi");
                    }
                }
                else
                {
                    MessageBox.Show("Campi vuoti", "avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel cambiare la password: " + ex.Message);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            SvuotaDati(txtEmail, txtPassword, txtConfermaPassword);
        }

        private void formRecuperaPassword_FormClosed(object sender, FormClosedEventArgs e)
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
