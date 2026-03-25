using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_4._1
{
    public class Prostokat : Figura
    {
        private double bok_a, bok_b;
        
        public Prostokat(double a, double b)
        {
            bok_a = a;
            bok_b = b;
        }
        public override double ObliczPole()
        {
            return bok_a * bok_b;
        }

    }
}
