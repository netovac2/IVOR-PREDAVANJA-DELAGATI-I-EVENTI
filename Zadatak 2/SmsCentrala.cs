using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class SmsCentrala
    {
        public delegate void NewPorukaDelegate(object s, SlanjePorukeEventArgs eventArgs);
        public event NewPorukaDelegate SlanjePorukeEvent;

        public List<Poruka> Poruke { get; set; }

        public SmsCentrala()
        {
            Poruke = new List<Poruka>();
        }

        public void SlanjePoruke(Poruka p)
        {
            Poruke.Add(p);
            SlanjePorukeEvent(this, new SlanjePorukeEventArgs()

            { 
                Poruka = p,
                TekstPoruke = p.TekstPoruke


            }) ;

        }

    }
}
