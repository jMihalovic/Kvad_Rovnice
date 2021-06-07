using System;

namespace KvadratickéRovnice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double VypocetDiskriminantu(double a, double b, double c)
        {
            double d = Math.Pow(b,2) - (4 * a * c);
            return d;
        }

        public static double VypocetKorenuMinus(double a, double b, double d)
        {
            double k1 = -b - Math.Sqrt(d) / 2 * a;
            return k1;
        }

        public static double VypocetKorenuPlus(double a, double b, double d)
        {
            double k2 = -b - Math.Sqrt(d) / 2 * a;
            return k2;
        }


    }
}
