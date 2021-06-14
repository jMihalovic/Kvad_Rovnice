using System;

namespace KvadratickéRovnice
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Zadejte první číslo (a)");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Zadejte druhé číslo (b)");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Zadejte třetí číslo (c)");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(KvadratickaRovnice(a, b, c));
                }
                catch
                {
                    Console.WriteLine("Příklad nemá řešení");
                }
            }
        }

        public static double VypocetDiskriminantu(double a, double b, double c)
        {
            double d = Math.Pow(b,2) - (4 * a * c);
            Exception ex = new Exception("Diskriminant vyšel záporný");
            if (d < 0) throw ex;
            else return d;
        }

        public static double VypocetKorenuMinus(double a, double b, double d)
        {
            double k = (-b - Math.Sqrt(d)) / (2 * a);
            return k;
        }

        public static double VypocetKorenuPlus(double a, double b, double d)
        {
            double k = (-b + Math.Sqrt(d)) / (2 * a);
            return k;
        }

        public static string KvadratickaRovnice(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0 && c != 0)
                {
                    return "Rovnice se nerovná";
                }
                else
                {
                    //xb + c =0
                    double x = -c / b;
                    return $"{x} * {b} + {c} = 0";
                }
            }
            else
            { 
                double d = VypocetDiskriminantu(a, b, c);
                double k1 = VypocetKorenuPlus(a, b, d);
                double k2 = VypocetKorenuMinus(a, b, d);
                return $@"ax² + bx + c = 0
D = {d}
x1    {a} * {Math.Pow(k1, 2)} + {b} * {k1} + {c} = 0
x2    {a} * {Math.Pow(k2, 2)} + {b} * {k2} + {c} = 0
";
            }
        }

    }
}
