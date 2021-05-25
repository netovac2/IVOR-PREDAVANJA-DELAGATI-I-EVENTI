using System;
using Zadatak_4;

namespace Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Sustav sustav = new Sustav();
            sustav.UlazUSustavEvent += Sustav_UlazUSustavEvent;
            sustav.UlazniSustav(new Klijent("Pero", "Peric"));

            Sustav sustav1 = new Sustav();
            sustav1.IzlazIzSustavaEvent += Sustav1_IzlazIzSustavaEvent;
            sustav1.IzlazniSustav(new Klijent("Ivo", "Ivic"));
        }

        

        private static void Sustav_UlazUSustavEvent(object s, UlazUSustavEventArgs eventArgs)
        {
            Console.WriteLine("Ulaz u sustav " + eventArgs.Ime);
        }



        private static void Sustav1_IzlazIzSustavaEvent(object a, UlazUSustavEventArgs eventArgs)
        {
            Console.WriteLine("Izlaz iz sustava " + eventArgs.Ime);
        }

    }
}
