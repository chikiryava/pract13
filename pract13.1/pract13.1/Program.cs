using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pract13._1
{
    class Program
    {
        static int Check()
        {
            while (true) {
                try
                {
                    int value = int.Parse(Console.ReadLine());
                    if (value < 0)
                        Console.WriteLine("Введите число больше нуля");
                    else
                        return value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
        }
        static void Pract13(ArrayList list)
        {
            ArrayList mylist = new ArrayList();
            while (true)
            {
                Console.WriteLine("Укажите количество элементов нового листа");
                try
                {
                    int items = Check();
                   
                    for(int i = 0; i < items; i++)
                    {
                        Console.WriteLine($"Введите {i} элемент");
                        mylist.Add(Console.ReadLine());
                    }
                    Console.WriteLine("Введите, с какого элемента вставлять новый лист");
                    int n1 = Check();                        
                    list.InsertRange(n1, mylist);
                    Console.WriteLine("Укажите количество элементов, которые нужно удалить");
                    int count = Check();
                    int n = n1 / 2;
                    for(int )
                   
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент", "Петров" });

            foreach(object e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[1]);
            Console.WriteLine();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Pract13(list);
            Console.ReadKey();
        }
    }
}
