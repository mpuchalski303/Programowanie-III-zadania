using System;
using System.Collections.Generic;
using System.Text;

namespace Samochody
{
    internal class Samochod : Pojazd
    {
        public override bool CzyToWieloslad()
        {
            return true;
        }
        public override bool CzyMaDach()
        {
            return true;
        }
        public override bool CzyUtonie()
        {
            return true;
        }
    }

}
