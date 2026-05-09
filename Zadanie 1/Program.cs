using System.Linq.Expressions;
namespace Zadanie1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    if (args.Length != 2)
                    {

                        Console.WriteLine("Blad");

                    }

                    long liczba1 = long.Parse(args[0]);

                    long liczba2 = long.Parse(args[1]);



                    long iloczyn = liczba1 * liczba2;

                    long reszta = liczba1 % liczba2;



                    Console.WriteLine(liczba1);

                    Console.WriteLine(liczba2);

                    Console.WriteLine(iloczyn);

                    Console.WriteLine(reszta);



                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Zla konwersja");

            }
            catch (DivideByZeroException)

            {
                Console.WriteLine("dzielenie przez 0");
            }

            catch (OverflowException)

            {

                Console.WriteLine("Wyjscie poza limit");

            }



        }

    }

}