using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takrorlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Array : ");
            string input = Console.ReadLine();
            int array;
            bool check = int.TryParse(input, out array);
            int[] arr = new int[array];

            for (int i = 0; i < array; i++)
            {
                int k = rnd.Next(1, 10);
                Console.Write(k + ", ");
                arr[i] = k;
            }

            Console.WriteLine();

            Array.Sort(arr);
            Console.WriteLine("O'sish tartibida tartiblangan ro'yxat:");
            foreach (int num in arr)
            {
                Console.Write(num + ", ");

            }

            int current = 0;
            int a = 0;

            Console.WriteLine();

            for (int i = 0;i < arr.Length; i++)
            { 
               
                if (i == 0) i++;
                int number = arr[i];
                int number1 = arr[i-1];
               
                if (number == number1)
                {
                    current++;
                    a++;
                }
                else
                {
                    if(a != 0)
                    {
                        Console.WriteLine($"{number-1} soni {current+1}ta");
                    }
                    current = 0;
                    a = 0;
                }
            }

            Console.ReadLine();
        }
    }
}
