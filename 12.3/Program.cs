using System;

namespace _12._3
{
    public class Node<T>
    {
        public Node(T[] data)
        {
            Data = data;
        }
        public T[] Data { get; set; }
        public Node<T> Next { get; set; }
    }
    class UnrolledList<T>
    {
        int size;
        public UnrolledList(int size)
        {
            this.size = size;
        }

        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T[] data)
        {
            if (data.Length != this.size)
            {
                System.Console.WriteLine("Неверный размер массива");
                return;
            }
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        private T[] GetTs(int num, Node<T> node)
        {
            if (num >= size || num < 0)
            {
                System.Console.WriteLine("Неверный индекс");
                return null;
            }
            if (num == 0)
            {
                return node.Data;
            }
            else
            {
                num--;
                return GetTs(num, node.Next);
            }
        }
        public T[] GetTs(int num)
        {
            return GetTs(num, this.head);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массивов");
            int n = int.Parse(Console.ReadLine());
            UnrolledList<int> list = new UnrolledList<int>(n);
            int[] arr;
            Console.WriteLine("Введите количество элементов");
            int k = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                arr = new int[n];
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = rnd.Next(-50,50);
                    Console.Write(arr[j] + " ");
                }
                Console.WriteLine();
                list.Add(arr);
            }
            Console.WriteLine("Введите индекс элемента которые хотите вывести");
            int[] array = list.GetTs(int.Parse(Console.ReadLine()));
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
