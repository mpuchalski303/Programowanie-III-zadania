using System;
using System.Collections;
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
            Console.WriteLine("Podaj ilosc kol");
            kola = int.Parse(Console.ReadLine());
        }
        public void UstawCene()
        {
            Console.WriteLine("Podaj cene");
            cena = int.Parse(Console.ReadLine());
        }
        public void UstawWage()
        {
            Console.WriteLine("Podaj wage");
            waga = int.Parse(Console.ReadLine());
        }
        public abstract bool CzyToWieloslad();
        public abstract bool CzyMaDach();
        public abstract bool CzyUtonie();

    }
}
