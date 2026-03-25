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
