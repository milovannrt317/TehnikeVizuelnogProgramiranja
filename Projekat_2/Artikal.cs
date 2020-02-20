using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_2
{
    class Artikal
    {
       public int id_artikla { get; set; } 
       public string naziv{ get; set; }
       public int cena{ get; set; }
       public int popust{ get; set; }
       public string slika { get; set; }

        public override string ToString()
        {
            return "Naziv: "+naziv+" Cena: "+cena+" RSD Popust: "+popust+" %";
        }
    }
}
