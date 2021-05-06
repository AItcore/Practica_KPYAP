using System;

namespace _4
{
    class Program
    {
        static void Twins()
        {
            int[] arr = new int[100];
            arr[0] = 2;
            arr[1] = 3;
            int count = 2;
            for (int i = 4; i <= 200; i++)
            {
                if (isSimple(i))
                {
                    arr[count] = i;
                    if (arr[count] - arr[count-1] == 2)
                        System.Console.WriteLine($"Близнецы: {arr[count-1]} и {arr[count]}");
                    count++;
                }
            }
        }
        static bool isSimple(int n)
        {
            bool prost = true;
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
        static void Main(string[] args)
        {
            Twins();
            MyData myData = new MyData(23,11,2002);
            myData.Show();
            myData.Year = 133;
            myData.Month = 6;
            myData.Day = 22;
            try
            {
                myData.Day = 100;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            myData.Show();
            myData.Add(14, 11, 66);
            myData.Show();
            myData.Add(643, 2523, 100);
            myData.Show();
            char[] array1 = new char[5]{'a','b','c','b','h'};
            char[] array2 = new char[5]{'a','b','c','b','h'};
            char[] array3 = new char[8]{'a','b','c','b','h','a','b','c'};
            Arr<char> myArray1 = new Arr<char>(array1);
            Arr<char> myArray2 = new Arr<char>(array2);
            Arr<char> myArray3 = new Arr<char>(array3);
            if (myArray1 == myArray2)
            {
                System.Console.WriteLine("Первый массив равен второму");
            }
            if (myArray1 == myArray3)
            {}
            else
            {
                System.Console.WriteLine("Первый массив не равен Третьему");
            }
            Console.ReadKey();
        }
    }
}
