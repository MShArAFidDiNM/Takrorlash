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
            Console.Write("Enter Row : ");
            string input = Console.ReadLine(); 
            int row = int.Parse(input);
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
