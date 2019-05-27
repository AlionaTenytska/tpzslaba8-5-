using System;
using System.Collections.Generic;

namespace tpzslaba8_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 2130; i++)
            {
                list.Add(rand.Next(400, 800));
            }
            list.Sort();
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            list.Insert(14, 15);

            int numeric = rand.Next(0, 15) + 500;

            Console.WriteLine("Сгенерированное новое число:{0}", numeric);

            if (list.Contains(numeric))
            {
                Console.WriteLine("\n Индекс: {0} ", list.IndexOf(numeric));
            }
            else
            {
                Console.WriteLine("\n Такого числа нет в списке!\n");
            }
            list.Remove(numeric);
            list.Clear();
            Console.ReadKey();
        }
    }
}
