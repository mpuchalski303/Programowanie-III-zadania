using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Zadanie_4._1
{
    public class Kwadrat : Figura
    {
        private double _bok;
        public double Bok
        {
            get { return _bok; }
            set
            {
                if (value >= 0) _bok = value;
                else
                {
                    throw new ArgumentException("Bok nie moze byc ujemny");
                }
            }
        }

        public Kwadrat(double a)
        {
            _bok = a;
        }
        public override double ObliczPole()
        {
            return _bok * _bok;
        }
    }
}
