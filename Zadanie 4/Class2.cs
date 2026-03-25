using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_4
{
    public class Kolo : Figura
    {
        private double _promien; 

        public Kolo(double r)
        {
            _promien = r;
        }
        public override double ObliczPole()

        {

            return _promien * _promien * Math.PI;

        }

    }
}
