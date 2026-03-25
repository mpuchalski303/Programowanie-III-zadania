namespace Zadanie_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> ListaFigur = new List<Figura>();
            ListaFigur.Add(new Kwadrat(5));
            ListaFigur.Add(new Kolo(3));

            ListaFigur.Add(new Prostokat(3, 7));
            foreach (Figura f in ListaFigur) {
                Console.WriteLine($"Pole figury to: {f.ObliczPole()}");
            }
            Figura mojaFigura = new Kwadrat(4.2);
            
            Console.WriteLine($"Pole to {mojaFigura.ObliczPole()}");
        }
    }
}
