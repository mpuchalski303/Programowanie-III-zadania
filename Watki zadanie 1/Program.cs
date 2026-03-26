/*
Napisz program w którym odczytane zostaną przynajmniej 4 różne stany wątku potomnego (slajd 14 z odpowiedniej prezentacji). Przetestuj jego działanie
 */

namespace Watki_zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread watek = new Thread(() => {
                
                Thread.Sleep(2000);
                

            });
            Console.WriteLine($"stan 0: {watek.ThreadState}");
            watek.Start();
            Console.WriteLine($"stan 1: {watek.ThreadState}");
            Thread.Sleep(100);
            Console.WriteLine($"stan 2: {watek.ThreadState}");
            watek.Join();
            Console.WriteLine($"stan 3: {watek.ThreadState}");
        }
    }
}
