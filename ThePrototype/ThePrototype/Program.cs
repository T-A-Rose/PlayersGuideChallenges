using System;

namespace ThePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            int PilotGuess;
            int HunterGuess;

            Console.WriteLine("Hello pilot, I need you to enter a number for the hunter to guess please?");

            do
            {
                PilotGuess = Convert.ToInt32(Console.ReadLine());
                if (PilotGuess < 0 || PilotGuess > 100)
                {
                    Console.WriteLine("Pilot, that number is out of bounds, please enter a number between 1 - 100!");
                }
            } while (PilotGuess < 0 || PilotGuess > 100);
            Console.Clear();

            Console.WriteLine("That's excellent, thank you pilot! Hunter, I now need you to guess the number the pilot just chose!");

            do
            {
                HunterGuess = Convert.ToInt32(Console.ReadLine());
                if (HunterGuess < PilotGuess) {
                    Console.WriteLine($"Hunter, the number {HunterGuess} is too low, please try again!");
                } else if (HunterGuess > PilotGuess) {
                    Console.WriteLine($"Hunter, the number {HunterGuess} is too high, please try again!");
                } else
                {
                    Console.WriteLine($"Congratulations Hunter, you guessed the number, the number you were looking for was {PilotGuess}");
                    break;
                }
            } while (HunterGuess != PilotGuess);
        }
    }
}
