using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class Sustav
    {

        public delegate void NewKlientDelegate(object s, UlazUSustavEventArgs eventArgs);
        public event NewKlientDelegate UlazUSustavEvent;

        public delegate void NewKlientDelegate1(object a, UlazUSustavEventArgs eventArgs);
        public event NewKlientDelegate1 IzlazIzSustavaEvent;



        public List<Klijent> Klijents { get; set; }

        public Sustav()
        {
            Klijents = new List<Klijent>();
        }

        public void UlazniSustav(Klijent k)
        {
            Klijents.Add(k);
            UlazUSustavEvent(this, new UlazUSustavEventArgs()
            { Ime = k.Ime,
              Prezime = k.Prezime,
              Klijent = k
            });
        }



        public void IzlazniSustav(Klijent k)
        {
            Klijents.Add(k);
            IzlazIzSustavaEvent(this, new UlazUSustavEventArgs()
            {
                Ime = k.Ime,
                Prezime = k.Prezime,
                Klijent = k
            });
        }

    }


}
