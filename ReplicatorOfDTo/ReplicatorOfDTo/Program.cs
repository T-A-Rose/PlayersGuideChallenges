using System;

namespace ReplicatorOfDTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] replicator = new int[5];

            Console.WriteLine("Hello programmer! We need you to input 5 values so we can store them in the replicator");

            for (int i = 0; i < replicator.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                replicator[i] = num;
            }

            int[] copiedArray = new int[5];

            for (int x = 0; x < copiedArray.Length; x++)
            {
                copiedArray[x] = replicator[x];
                Console.WriteLine($"Value of replicator array: {replicator[x]}");
                Console.WriteLine($"Value of copied array: {copiedArray[x]}");
            }

            Console.ReadLine();
        }
    }
}
