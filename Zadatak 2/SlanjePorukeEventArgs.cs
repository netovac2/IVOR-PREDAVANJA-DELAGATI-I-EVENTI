using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class SlanjePorukeEventArgs : EventArgs
    {


        public string TekstPoruke { get; set; }
        public Poruka Poruka { get; set; }


    }
}
