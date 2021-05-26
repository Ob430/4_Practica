using System;
using System.Collections;

namespace PR4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            ArrayList al2;

            list.AddRange(new string[] { "1" , "b", "3", "c", "5", "6", "7"
            , "8"  , "9"  , "10"  , "11"  , "12"  , "13"  , "14"  , "15"  , "16"});
            // заносим в список строковый массив

            // перебор значений
            for (int i = 0; i < list.Count; i++)
            {
                list.RemoveRange(1, 3); // удаляем буквы

                list.Add(10);
                list.Add(20);
                list.Add(30);

                al2 = (ArrayList)list.Clone(); // записываю в другую колекцию

                al2.Remove(20); // al = [10, 20, 30]; al2 = [10, 30]

                Console.WriteLine(list[i]); //все вывожу
                //Console.WriteLine(al2);
            }

            Console.ReadLine();
        }
    }
}
