using System;
using System.Collections.Generic;
using System.Text;

namespace Watki_zadanie_3
{
    internal class Pisarz
    {
        
        public void Wypisz(object dane)
        {
            lock (this)
            {
                string nazwaWatku = Thread.CurrentThread.Name;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{nazwaWatku} , {i}");
                    Thread.Sleep(10);

                }
                Console.WriteLine("KONIEC");
            }


        }
    }
}
