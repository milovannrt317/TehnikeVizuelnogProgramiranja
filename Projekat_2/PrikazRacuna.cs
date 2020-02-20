using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class PrikazRacuna
    {
        public int id_artikla { get; set; }
        public string naziv { get; set; }
        public double cena { get; set; }
        public double popust { get; set; }
        public int kolicina { get; set; }
        public override string ToString()
        {
            return "- " + naziv + " Cena: " + cena + " Popust: " + popust+"% Količina: "+kolicina;
        }
    }
}
