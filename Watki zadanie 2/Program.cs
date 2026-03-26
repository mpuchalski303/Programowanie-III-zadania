/*
 Stwórz wątek za pomocą metody anonimowej, wypisujący listę liczb od 1 do 100.
 */
namespace Watki_zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread watek = new Thread(() =>{
                for(int i = 1; i < 101; i++)
                {
                    Console.Write($" {i}");
                }
            });
            watek.Start();
        }
    }
}
