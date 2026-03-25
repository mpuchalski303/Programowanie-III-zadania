namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                

                if( args.Length > 0)
                {

                    double promien = double.Parse(args[0]);
                    if(promien < 0)
                    {
                        throw new Exception("Promien nie moze byc ujemny");
                    }
                    if(promien == 0)
                    {
                        throw new Exception("Promien nie moze byc rowny 0");
                    }
                    double Pole = Math.PI * promien * promien;
                    Console.WriteLine($"Pole wynosi: {Pole}");
                }
                else
                {
                    Console.WriteLine("Brak danych");
                }
                

            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
