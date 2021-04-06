using System;

namespace ClassLibrary
{
    public class MyClass
    {
        public static void SortOrder(ref int[] arr)
        {
            Array.Sort(arr);
        }
        public static void AnotherSortOrder(ref int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
    }

}
