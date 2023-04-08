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
            Console.Write("STR1 ni kiriting : ");
            string s1 = Console.ReadLine();

            Console.Write("STR2 ni kiriting : ");
            string s2 = Console.ReadLine();

            bool isPresent = s1.Contains(s2);
            Console.WriteLine(isPresent);

            Console.ReadLine();
        }
    }
}
