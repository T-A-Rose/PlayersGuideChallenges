using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheClocktower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The clocktower is damaged, it needs an odd or an even number to double check it's functioning correctly, can you enter one to test it?");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Tick");
            } else
            {
                Console.WriteLine("Tock");
            }
            Console.ReadLine();

        }
    }
}
