using System;
using System.Collections.Generic;
using System.Text;

namespace Srednie
{
    internal class SredniaHarmoniczna : Isrednia
    {
        public double ObliczSrednia(double[] liczby)
        {
            double suma = 0;
            foreach(double l in liczby)
            {
                suma += 1 / l;
            }
            return liczby.Length /suma;
        }
    }
}
