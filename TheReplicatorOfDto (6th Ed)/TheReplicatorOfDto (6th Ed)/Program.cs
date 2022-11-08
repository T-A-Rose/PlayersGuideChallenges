namespace TheReplicatorOfDto
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers");
            int[] firstArray = new int[5];
            
            for (int i = 0; i < firstArray.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                firstArray[i] = num;
            }

            int[] copiedArray = new int[5];
            Array.Copy(firstArray, copiedArray, 5);

            DisplayArray(firstArray);
            DisplayArray(copiedArray);
            Console.ReadLine();
        }

        static void DisplayArray(int[] arr)
        {            
            foreach (int i in arr)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
        }

    }
}

