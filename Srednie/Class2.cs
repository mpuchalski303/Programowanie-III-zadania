using System;
using System.Collections.Generic;
using System.Text;

namespace Srednie
{
    internal class Sredniageometryczna : Isrednia
    {
        
        public double ObliczSrednia(double[] liczby)
        {
            double wynik = 1;
            foreach(double i in liczby)
            {
                wynik *= i;

            }
            return Math.Pow(wynik, 1.0/liczby.Length);
        }
    }
}
