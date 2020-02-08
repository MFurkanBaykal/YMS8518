using System;

namespace Vekiller2
{
    class Program
    {
        public static int Carp(int x, int y)
        {
            return x * y;
        }
        public static int Bol(int x, int y)
        {
            return x / y;
        }
        public static int Topla(int x, int y)
        {
            return x + y;
        }
        public static int Cikar(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> testDelegate = Bol;
            int cikti = testDelegate(2, 3);
            Console.WriteLine(cikti);

            testDelegate = Carp;
            cikti = testDelegate(4, 5);
            Console.WriteLine(cikti);
            Console.ReadLine();
        }
    }
}
