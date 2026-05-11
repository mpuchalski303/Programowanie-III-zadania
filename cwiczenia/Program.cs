using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace cwiczenia
{
    internal class Program
    {
        
        

        static void Main(string[] args)
        {
            object blokada = new object();
            ThreadStart akcjaWatku = () =>
            {
                for (int i = 1; i <= 4; i++)
                {
                    lock (blokada)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name},krok {i} poczatek");
                        Thread.Sleep(3000);
                        Console.WriteLine($"{Thread.CurrentThread.Name},krok {i} koniec");
                    }
                }
            };  
            
            Thread watek1 = new Thread( akcjaWatku );
            watek1.Name = "W1";
            Thread watek2 = new Thread(akcjaWatku);
            watek2.Name = "W2";

            watek1.Start();
            watek2.Start();

            watek1.Join();
            watek2.Join();


        }
        
    }
}
