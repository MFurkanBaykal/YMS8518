using System;

namespace Vekiller
{
    class Program
    {
        public delegate void TestDelegate(int x, int y);

        public static void Topla(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Cikart(int x, int y)
        {
            Console.WriteLine(x - y);

        }
        public static void Carp(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void Bol(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main(string[] args)
        {
          TestDelegate  
            test = Topla;
            test(10, 5);
            test = Cikart;
            test(10, 5);
            test = Carp;
            test(10, 5);
            test = Bol;
            test(10, 5);

            Console.ReadLine();
        }
    }
}
