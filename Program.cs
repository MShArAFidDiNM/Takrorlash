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
            Console.Write("Satrni kiriting: ");
            string satr = Console.ReadLine();

            string kichikSatr = satr.ToLower();
            Console.WriteLine("Natija: " + kichikSatr);
            
            Console.ReadLine();
        }
    }
}
