using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace _8
{
    enum CharacterType
    {
        Charismatic = 3,
        Evil = -5,
        HighlyСlassified = 7,
        Fair = 4,
        Dishonest = -3
    }
    struct Professor
    {
        public List<CharacterType> types;
    }
    struct Product : IComparable
    {
        public string type;
        public int price;
        public string variety;
        public int count;
        public int CompareTo(object obj)
        {
            Product otherProduct = (Product)obj;
            return count.CompareTo(otherProduct.count);
        }
        public string ToString()
        {
            return $"{this.type}\n{this.price}\n{this.variety}\n{this.count}";
        }
    }
    class Program
    {
        static void OptimalProfessor(Professor[] professors)
        {
            int[] arr = new int[professors.Length];
            for (int i = 0; i < professors.Length; i++)
            {
                arr[i] = 0;
                foreach (int item in professors[i].types)
                {
                    arr[i] += item;
                }
                System.Console.WriteLine($"Преподователь №{i + 1} баллов: {arr[i]}");
            }
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[max] < arr[i])
                {
                    max = i;
                }
            }
            System.Console.WriteLine($"Лучший преподователь №{max} баллов: {arr[max]}");
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задание №1");
            System.Console.Write("Количество преподователей: ");
            Professor[] professors = new Professor[int.Parse(Console.ReadLine())];
            for (int i = 0; i < professors.Length; i++)
            {
                professors[i] = new Professor();
                professors[i].types = new List<CharacterType>();
                int choose = 0;
                bool work = true;
                while (work)
                {
                    System.Console.WriteLine("0 - След. преподаватель 1 - Харизматичный 2 - Злой 3 - Высоко классифицированный 4 - Честный 5 - Не честный");
                    choose = int.Parse(Console.ReadLine());
                    CharacterType type = CharacterType.Charismatic;
                    switch (choose)
                    {
                        case 0:
                            work = false;
                            break;
                        case 1:
                            professors[i].types.Add(CharacterType.Charismatic);
                            break;
                        case 2:
                            professors[i].types.Add(CharacterType.Evil);
                            break;
                        case 3:
                            professors[i].types.Add(CharacterType.HighlyСlassified);
                            break;
                        case 4:
                            professors[i].types.Add(CharacterType.Fair);
                            break;
                        case 5:
                            professors[i].types.Add(CharacterType.Dishonest);
                            break;
                    }
                }
            }
            OptimalProfessor(professors);
            // string path = "/home/kirill/coding/python/Practica_KPYAP/8/";
            // StreamReader reader = new StreamReader(path + "input.txt");
            // StreamWriter writer = new StreamWriter(path + "output.txt");
            // Product[] products = new Product[3];
            // int i = 0;
            // while (!(reader.Peek() == -1))
            // {
            //     products[i].type = reader.ReadLine();
            //     products[i].price = int.Parse(reader.ReadLine());
            //     products[i].variety = reader.ReadLine();
            //     products[i].count = int.Parse(reader.ReadLine());
            //     i++;
            // }
            // Array.Sort(products);
            // System.Console.WriteLine("Введите максимальное количество продуктов");
            // int a = int.Parse(Console.ReadLine());
            // for (i = 0; i < products.Length; i++)
            // {
            //     if (products[i].count < a )
            //     {
            //         writer.WriteLine(products[i].ToString());
            //     }
            // }
            // writer.Close();
            // reader.Close();
        }
    }
}
