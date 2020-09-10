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
    public partial class formPrenotaFilm : Form
    {
        // variaibli che arrivano dal form dashboard
        private string _username;
        private string _generepreferito;
        // inizializzo delle variabili
        public string connectionstring;
        public SqlConnection connection;
        public SqlCommand cmd;
        public int IdGenerePreferito;
        public int idutente;


        public formPrenotaFilm(string username, string generepreferito)
        {
            InitializeComponent();
            this._username = username;
            this._generepreferito = generepreferito;
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

        // funzione che ritorna l id del genere 
        public int RitornaIdGenere(string genere)
        {
            int x;
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select IdGenere from Genere where Genere.nomeGenere=@nomeGenere", connection);
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

        // funzione che carica solo il film del genere preferito
        public DataTable CaricaFilmGenerePreferito()
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

        // funzione che carica tutti i film
        public DataTable CaricaFilm()
        {
            DataTable tb = new DataTable();
            cmd = new SqlCommand("select idFilm,nomeFilm,dataUscita from Film where Film.numeroCopie>0 AND Film.disponibile=1", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(tb);
            return tb;
        }

        // funzione che effettua la prenotazione
        public bool RegistraPrenotazione(Prenotazione p)
        {
            bool check;
            DataTable tb = new DataTable();
            int copie = 0;
            cmd = new SqlCommand("INSERT INTO Prenotazioni (idUtente,idFilm,dataInizio,dataFine,GiorniRitardo) VALUES (@idutente, @idfilm,@datainizio, @datafine,@giorniritardo)", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idutente", SqlDbType.Int).Value = p.idUtente;
            cmd.Parameters.Add("@idfilm", SqlDbType.Int).Value = p.idFilm;
            cmd.Parameters.Add("@datainizio", SqlDbType.Date).Value = p.dataInizio;
            cmd.Parameters.Add("@datafine", SqlDbType.Date).Value = p.dataFine;
            cmd.Parameters.Add("@giorniritardo", SqlDbType.Int).Value = p.giorniRitardo;
            int x= cmd.ExecuteNonQuery();
            if (x == 1)
            {
                SqlCommand cmd2 = new SqlCommand("SELECT numeroCopie FROM Film WHERE Film.idFilm=@idfilm", connection);
                cmd2.Connection = connection;
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("@idfilm", SqlDbType.Int).Value = p.idFilm;
                cmd2.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd2;
                adp.Fill(tb);
                copie = Convert.ToInt32(tb.Rows[0][0]);
                if (copie > 1)
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Film SET numeroCopie=numeroCopie-1 WHERE Film.idFilm=@idfilm", connection);
                    cmd3.Connection = connection;
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.Add("@idfilm", SqlDbType.Int).Value = p.idFilm;
                    cmd3.ExecuteNonQuery();
                }
                else if(copie<=1)
                {
                    SqlCommand cmd4 = new SqlCommand("UPDATE Film SET numeroCopie=numeroCopie-1, disponibile=0 WHERE Film.idFilm=@idfilm", connection);
                    cmd4.Connection = connection;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Parameters.Add("@idfilm", SqlDbType.Int).Value = p.idFilm;
                    cmd4.ExecuteNonQuery();
                }
                check = true;
            }
            else
                check = false;

            return check;
        }

        // funzione che svuota i controlli
        public void SvuotaDati(ComboBox cmb1, CheckBox chk)
        {
            cmb1.SelectedIndex =0;
            chk.Checked = false;
        }

        // Trovo l'id del film 
        public int TrovaIdFilm(string nomeFilm) {
            int id;
            SqlCommand cmd3 = new SqlCommand("SELECT idFilm FROM Film WHERE Film.nomeFilm=@nomefilm", connection);
            cmd3.Connection = connection;
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("@nomefilm", SqlDbType.VarChar,255).Value =nomeFilm;
            cmd3.ExecuteNonQuery();
            DataTable tb = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd3;
            adp.Fill(tb);
            id = Convert.ToInt32(tb.Rows[0][0]);
            return id;
        }

        private void formPrenotaFilm_Load(object sender, EventArgs e)
        {
            try
            {
                // connessione al database
                connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\Database\VideotecaDB.mdf;Integrated Security=True;Connect Timeout=30";
                connection = new SqlConnection(connectionstring);
                connection.Open();
                // stampo nelle rispettive caselle di testo l'username e il genere preferito
                txtPrenotaFIlmGenerePreferito.Text = this._generepreferito;
                txtPrenotaFilmUsername.Text = this._username;
                // salviamo l id del genere preferito
                IdGenerePreferito = RitornaIdGenere(this._generepreferito);
                // salviamo l'id utente
                idutente = RitornaIdUtente(this._username);
                // controllo se vuole vedere solo i film consigliati o no
                if (!chkPrenotaFilmGenerePreferito.Checked)
                {
                    cmbPrenotaFilmElencoFilm.DataSource = CaricaFilmGenerePreferito();
                    cmbPrenotaFilmElencoFilm.DisplayMember = "nomeFilm";
                    cmbPrenotaFilmElencoFilm.ValueMember = "nomeFilm";
                }
                else
                {
                    // carico tutti i film
                    cmbPrenotaFilmElencoFilm.DataSource = CaricaFilm();
                    cmbPrenotaFilmElencoFilm.DisplayMember = "nomeFilm";
                    cmbPrenotaFilmElencoFilm.ValueMember = "nomeFilm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento: " + ex.Message);
            }
        }

        private void chkPrenotaFilmGenerePreferito_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPrenotaFilmGenerePreferito.Checked)
            {
                cmbPrenotaFilmElencoFilm.DataSource = CaricaFilmGenerePreferito();
                cmbPrenotaFilmElencoFilm.DisplayMember = "nomeFilm";
                cmbPrenotaFilmElencoFilm.ValueMember = "nomeFilm";
            }
            else
            {
                // carico tutti i film
                cmbPrenotaFilmElencoFilm.DataSource = CaricaFilm();
                cmbPrenotaFilmElencoFilm.DisplayMember = "nomeFilm";
                cmbPrenotaFilmElencoFilm.ValueMember = "nomeFilm";
            }
        }

        private void btnPrenotafilm_Click(object sender, EventArgs e)
        {
            try
            {
              if(txtPrenotaFIlmGenerePreferito.Text!=""&& txtPrenotaFilmUsername.Text != ""){

                    Prenotazione prenotazione = new Prenotazione();
                    prenotazione.idFilm = TrovaIdFilm(cmbPrenotaFilmElencoFilm.Text);
                    prenotazione.idUtente = idutente;
                    prenotazione.dataInizio = DateTime.Now;
                    prenotazione.dataFine = DateTime.Now.AddDays(7);
                    prenotazione.giorniRitardo = 0;
                    if (RegistraPrenotazione(prenotazione))
                    {
                        MessageBox.Show("Film prenotato correttamente");
                        SvuotaDati(cmbPrenotaFilmElencoFilm, chkPrenotaFilmGenerePreferito);
                    }
                    else { MessageBox.Show("Errore nella prenotazione"); }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errore nel prenotare il film" + ex.Message);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            SvuotaDati(cmbPrenotaFilmElencoFilm, chkPrenotaFilmGenerePreferito);
        }
    }
}
