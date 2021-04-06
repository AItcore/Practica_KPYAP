using System;
using System.Linq;

namespace MyLib2
{
    public class Sorting
    {
        public static void Asc(ref int[,] arr)
        {
            int[] temp = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                    temp[j] = arr[i, j];
                Array.Sort(temp);
                for (int k = 0; k < arr.GetLength(0); k++)
                {
                    arr[i, k] = temp[k];
                }
            }
        }
        public static void Desc(ref int[,] arr)
        {
            int[] temp = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                    temp[j] = arr[i, j];
                Array.Sort(temp);
                Array.Reverse(temp);
                for (int k = 0; k < arr.GetLength(0); k++)
                {
                    arr[i, k] = temp[k];
                }
            }
        }
    }
}
