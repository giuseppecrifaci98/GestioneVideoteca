using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneVideoteca.Classi
{
   public class Utenti
    {
        public int idUtente { get; set; }
        public string cognome { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int idCitta { get; set; }
        public int idGenere { get; set; }
        public int isAdministrator { get; set; }
    }
}
