using System;
using System.Collections.Generic;
using System.Text;
using Zadanie_4._1;

namespace Zadanie_4
{
    public class Kolo : Figura, IDrawable
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
        public string Draw()
        {
            return $"Rysuje";
        }

    }
}
