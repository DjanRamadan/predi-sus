using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predi_sustezanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some numbers here: ");
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.Write("Enter a command here: ");
            var com = Console.ReadLine();

            while (com!="Odd" && com!="Even")
            {
                var arr = com.Split(' ').ToArray();
                if (arr[0] == "Delete")
                {
                    var num = int.Parse(arr[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == num)
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                else if (arr[0] == "Insert")
                {
                    var num1 = int.Parse(arr[1]);
                    var num2 = int.Parse(arr[2]);
                    list.Insert(num2, num1);
                }
                Console.Write("Enter a command here: ");
                com = Console.ReadLine();
            }

            if (com == "Odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (com == "Even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        Console.Write(list[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}