using System;

namespace Buying_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            String response;
            float ExactPrice;
            Console.WriteLine("Welcome to the Outfitter! To make a selection please put just the number of the item you're after!");
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What number do you want to see the price of?");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Excellent, quick question though, what was your name please?");
            String name = Console.ReadLine();

            ExactPrice = choice switch
            {
                1 => 10,
                2 => 15,
                3 => 25,
                4 => 1,
                5 => 20,
                6 => 200,
                7 => 1,
                _ => 0
            };

            response = choice switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "CLean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies",
                _ => "Sorry, that item isn't available right now! PLease feel free to check back later!"
            };


            if (name == "Tom")
            {
                ExactPrice = ExactPrice / 2;
            }

            Console.WriteLine($"{response}, that will be {ExactPrice} gold please!");
            
        }
    }
}
