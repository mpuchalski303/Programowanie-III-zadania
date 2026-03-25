using System;
using System.Collections.Generic;
using System.Text;

namespace Samochody
{
    internal abstract class Pojazd
    {
        private int miejsca, kola, cena, waga;
        public void UstawIloscMiejsc()
        {
            Console.WriteLine("Podaj ilosc miejsc");
            miejsca = int.Parse(Console.ReadLine());
        }
        public void UstawiIloscKol()
        {
            Console.WriteLine("Podaj ilosc miejsc");
            miejsca = int.Parse(Console.ReadLine());
        }
        public void UstawCenę()
        {
            Console.WriteLine("Podaj ilosc miejsc");
            miejsca = int.Parse(Console.ReadLine());
        }

    }
}
