using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class Klijent
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Klijent(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }


        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
