using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionOfKings
{
    class Program
    {
        static void Main(string[] args)
        {

            int estate, duchy, province, total;
            estate = 1;
            duchy = 3;
            province = 6;

            Console.WriteLine("Please enter how many estates you own!");
            int userEstateTot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter how many duchy you own!");
            int userDuchyTot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter how many province you own!");
            int userProvinceTot = Convert.ToInt32(Console.ReadLine());

            estate = estate * userEstateTot;
            duchy = duchy * userDuchyTot;
            province = province * userProvinceTot;

            total = estate + duchy + province;

            Console.WriteLine("You currently own " + estate + " points worth of estates, " + duchy + " duchy's and finally " + province + " points worth of provinces. For a combined total of " + total);
            Console.ReadLine();

        }
    }
}
