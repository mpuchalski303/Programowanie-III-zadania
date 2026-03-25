/*
 
Do projektu dodaj klasę abstrakcyjną Pojazd z polami miejsca, kola, cena, waga, zaimplementowanymi metodami UstawIloscMiejsc(-), UstawiIloscKol(-), UstawCenę(-), UstawWagę(-) 
oraz abstrakcyjnymi metodami CzyToWieloslad(), CzyMaDach(), CzyUtonie().

Stwórz klasy Samochod, Rower, Lodz dziedziczące po klasie Pojazd (i implementujące wszystkie abstrakcyjne metody).
 */

namespace Samochody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pojazd row1 = new Rower();
            Pojazd sam1 = new Samochod();
            Pojazd lodz1 = new Lodz();

            row1.UstawCene();
            Console.WriteLine(row1.CzyMaDach());
            Console.WriteLine(sam1.CzyToWieloslad());
            Console.WriteLine(lodz1.CzyUtonie());
        }
    }
}
