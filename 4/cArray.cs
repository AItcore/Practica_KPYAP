using System;

namespace _4
{
   partial class Arr<T>
   {
      private T[] arr;
      public Arr(T[] arr)
      {
         this.arr = arr;
      }
      public static bool operator ==(Arr<T> myArr1, Arr<T> myArr2)
      {
         if (myArr1.arr.Length != myArr2.arr.Length)
         {
            return false;
         }
         else
         {
            for (int i = 0; i < myArr1.Array.Length; i++)
            {
               if (Convert.ToChar(myArr1.Array[i]) != Convert.ToChar(myArr2.Array[i]))
               {
                  return false;
               }
            }
         }
         return true;
      }
      public static bool operator !=(Arr<T> myArr1, Arr<T> myArr2)
      {
         if (myArr1.arr.Length != myArr2.arr.Length)
         {
            return true;
         }
         else
         {
            for (int i = 0; i < myArr1.Array.Length; i++)
            {
               if (Convert.ToChar(myArr1.Array[i]) != Convert.ToChar(myArr2.Array[i]))
               {
                  return true;
               }
            }
         }
         return false;
      }
      public T[] Array { get => arr; }
   }
}