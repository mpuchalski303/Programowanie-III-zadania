namespace cwiczenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MinMax(out int minint, out int maxint, 1, 2, 3, 4, 5, -10);
                Console.WriteLine($"{minint}, {maxint}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                MinMax(out float minint, out float maxint, 1.2f , 3.4f , 0.2f , 4, 12.3f, -10);
                Console.WriteLine($"{minint}, {maxint}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                MinMax(out string minint, out string maxint, "jeden" , "dwa", "trzy");
                Console.WriteLine($"{minint}, {maxint}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="args"></param>
        public static void MinMax<T>(out T min, out T max, params T[] args) where T : IComparable<T>
        {
            if (args.Length == 0 || args == null)
            {
                throw new ArgumentException("Zle");
            }
            min = args[0];
            max = args[0];
            foreach(T item in args)
            {
                if(item.CompareTo(min) < 0)
                {
                    min = item;

                }
                if(item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
        }
    }
}
