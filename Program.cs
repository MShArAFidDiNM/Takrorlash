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

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    Console.WriteLine(str[i]);
                }
                else break;
            }

            Console.ReadLine();

        }
    }
}
