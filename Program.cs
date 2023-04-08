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
            Console.Write("Satrni kiriting : ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 2)
                {
                    Console.Write(str[str.Length - 1]);
                    break;
                }
                else Console.Write(str[i]);
            }

            Console.Write(str[str.Length-2]);
            Console.ReadLine();

        }
    }
}
