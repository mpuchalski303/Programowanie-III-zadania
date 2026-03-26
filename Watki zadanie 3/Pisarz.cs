using System;
using System.Collections.Generic;
using System.Text;

namespace Watki_zadanie_3
{
    internal class Pisarz
    {
        
        public void Wypisz(object dane)
        {
            dane = dane.ToString();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(dane);
                
            }


        }
    }
}
