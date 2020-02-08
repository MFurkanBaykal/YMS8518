using System;

namespace Vekiller3
{
    class Program
    {
        public static string ConcattedString = string.Empty;
        public static void Concat(string ilk, string son)
        {
            ConcattedString = ilk + son;
            Console.WriteLine(ilk + son);
            
        }
        static void Main(string[] args)
        {
            Action<string, string> testDelegate = Concat;
            testDelegate("x","y");
            Console.WriteLine("Singelton'dan gelen nesne: " + ConcattedString);

            Console.ReadLine();
            
        }
    }
}
