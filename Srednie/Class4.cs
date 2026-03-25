using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Srednie
{
    internal class SredniaKwadartowa : Isrednia
    {
        public double ObliczSrednia(double[] liczby)
        {
            double suma = 0;
            foreach(double l in liczby)
            {
                suma += Math.Pow(l, 2);
            }
            return Math.Pow(suma/liczby.Length, 0.5);
        }
        
    }
}
