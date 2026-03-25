
/*
 
Utwórz nowy projekt o nazwie Srednie. Utwórz w nim interfejs ISrednia z metodą ObliczSrednia(-) przyjmującą jako argument 
tablicę liczb typu double oraz zwracającą liczbę double. Następnie stwórz klasy implementujące interfejs ISrednia:

SredniaArytmetyczna,
SredniaGeometryczna,
SredniaHarmoniczna,
SredniaKwadratowa,
w których metoda ObliczSrednia() będzie wyliczać średnią zgodnie ze wzorem odpowiadającym nazwie klasy.

W metodzie Main klasy Program utwórz tablicę liczb typu double i wypełnij ją przykładowymi wartościami.
Utwórz obiekty utworzonych wcześniej klas i wypisz na standardowe wyjście wartości wyliczonych średnich.

 */

namespace Srednie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] liczby = new double[5] {5,12 ,3 ,6,4};

            SredniaArytmetyczna Sr1 = new SredniaArytmetyczna();
            Sredniageometryczna Sr2 = new Sredniageometryczna();
            SredniaHarmoniczna Sr3 = new SredniaHarmoniczna();
            SredniaKwadartowa Sr4 = new SredniaKwadartowa();

            Console.WriteLine(Sr1.ObliczSrednia(liczby));
            Console.WriteLine(Sr2.ObliczSrednia(liczby));
            Console.WriteLine(Sr3.ObliczSrednia(liczby));
            Console.WriteLine(Sr4.ObliczSrednia(liczby));
        }
    }
}
