using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Srednie
{
    internal class SredniaArytmetyczna : Isrednia
    {
        
        
        public double ObliczSrednia(double[] liczby)
        {

            double suma = 0;
            foreach(double i in liczby)
            {
                suma += i;
            }
            return suma/liczby.Length;
        }
    }
}
