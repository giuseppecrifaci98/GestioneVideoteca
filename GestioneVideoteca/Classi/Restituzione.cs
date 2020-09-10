using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneVideoteca.Classi
{
    public class Restituzione
    {
        public int idPrenotazione{get;set;}
        public int idFilm { get; set; }
        public int idUtente { get; set; }
        public int GiorniRitardo { get; set; }
    }
}
