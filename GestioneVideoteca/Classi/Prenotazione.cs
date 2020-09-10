using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneVideoteca.Classi
{
   public  class Prenotazione
    {
        public int idUtente { get; set; }
        public int idFilm { get; set; }
        public DateTime dataInizio { get; set; }
        public DateTime dataFine { get; set; }
        public int giorniRitardo { get; set; }
    }
}
