using System;

namespace _3
{
    class ClassLibrary
    {
        public ClassLibrary()
        {
            
        }
        public static double Progres(int a)
        {
            double res;
            if (isSimple(a))
            {
                res = 1;
                System.Console.WriteLine("Число простое");
                for (int i = 1; i <= a; i += 3)
                {
                    res *= Math.Pow(a, i);
                }
            }
            else
            {
                res = 0;
                System.Console.WriteLine("Число не простое");
                for (int i = 1; i <= a; i += 3)
                {
                    res += i;
                }
            }
            return res;
        }
        private static bool isSimple(int n)
        {
            bool prost = true;
            Console.WriteLine("Введите число\n");
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            return prost;
        }
    }
}