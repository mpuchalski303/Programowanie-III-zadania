using System.Text.Json.Serialization;

namespace Zadanie_5
{
    internal class Program
    {

        static void Podziel(double a, double b, ref double wynik)
        {
            wynik = a / b;
        }
        static double SumaPol(params double[] pola)
        {
            double wynik = 0;
            foreach(double d in pola)
            {
                wynik += d;
            }
            return wynik;
        }

        static void Main(string[] args)
        {
            double wynik = 0;

            Podziel(8,2,ref wynik);
            Console.WriteLine(wynik);

            List<double> l = new List<double>();

           
            Console.WriteLine(SumaPol(10,5,12));
        }
    }
}
