using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class IzlazIzSutavaEventArgs:EventArgs
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Klijent Klijent { get; set; }
    }
}
