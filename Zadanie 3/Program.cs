namespace Zadanie_3
{
    internal class Program
    {
        public interface IWypisz
        {
            string Wypisz();
        }
        public abstract class Figura
        {
            protected readonly DateTime Utworzono;
            protected Figura()
            {
                Utworzono = DateTime.Now;
            }
        }
        public abstract class Wielokat : Figura, IWypisz
        {
            public virtual string Wypisz()
            {
                return $"Wielokat: {Utworzono}";
            }
        }
        public class kolo : Figura, IWypisz
        {
            public virtual string Wypisz()
            {
                return $"kolo: {Utworzono}";
            }
        }
        public class Prostokat : Wielokat
        {
            public override string Wypisz()
            {
                return $"Prostokat: {Utworzono}";
            }
        }
        public class Trojakt : Wielokat
        {
            public override string Wypisz()
            {
                return $"Trojakt: {Utworzono}";
            }
        }
        public class Kwadrat : Prostokat
        {
            public override string Wypisz()
            {
                return $"Kwadrat: {Utworzono}";
            }
        }
        static void Main(string[] args)
        {
            Wielokat wiel1 = new Kwadrat();
            IWypisz kolo1 = new kolo();

            Console.WriteLine(wiel1.Wypisz());
            Console.WriteLine(kolo1.Wypisz());
        }
    }
}
