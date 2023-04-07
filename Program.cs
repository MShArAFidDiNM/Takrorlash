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
            Console.Write("1-satrni kiriting : ");
            string intputstr1 = Console.ReadLine();
            Console.Write("2-satrni kiriting : ");
            string intputstr2 = Console.ReadLine();

            for (int i = 1; i < intputstr1.Length + intputstr2.Length;  i++)
            {
                if (i == intputstr1.Length) continue;
                else Console.Write((intputstr1 + intputstr2)[i]);
            }

            Console.ReadLine();

        }
    }
}
