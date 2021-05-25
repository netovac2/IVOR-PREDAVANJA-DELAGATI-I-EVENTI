using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SmsCentrala smsCentrala = new SmsCentrala();
            smsCentrala.SlanjePorukeEvent += Sustav_SlanjaPoruke;
            smsCentrala.SlanjePoruke(new Poruka("Ovo je poslana poruka!!!!"));
            
        }

        
        private static void Sustav_SlanjaPoruke(object p, SlanjePorukeEventArgs eventArgs)
        {
            Console.WriteLine("Poslana je poruka: " + eventArgs.TekstPoruke);
        }


    }
}
