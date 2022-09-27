using PackingInventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Run
    {

        Pack pack = new(5, 10.0, 30.00);

        static public void Main(String[] args)
        {
            GetItems();
        }

        public void GetItems()
        {
           bool test = pack.Add(new Sword());
            Console.WriteLine(test);

            Console.WriteLine("Hello adventurer, please select an item to add to your pack, although please bare in mind you can only carry so much!");
            Console.WriteLine("The options are as follows: Sword, Bow, Arrow, Food, Water & finally Rope");
 
            while (true)
            {
                string selectedItem = Console.ReadLine().ToLower();

                var isValid = selectedItem switch
                {
                    "sword" => pack.Add(new Sword()),
                    "bow" => pack.Add(new Bow()),
                    "arrow" => pack.Add(new Arrow()),
                    "food" => pack.Add(new Food()),
                    "water" => pack.Add(new Water()),
                    "rope" => pack.Add(new Rope()),
                    _ => throw new Exception()
                };
                if (!isValid) Console.Write("Not valid");
                pack.DisplayItems();
            }
        }

    }
}
