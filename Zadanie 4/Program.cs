namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura mojaFigura = new Kolo(10);
            Console.WriteLine($"Pole to {mojaFigura.ObliczPole()}");
        }
    }
}
