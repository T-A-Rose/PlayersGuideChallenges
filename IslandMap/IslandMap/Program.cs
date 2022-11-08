using Microsoft.VisualBasic;

int[,] mapArray = new int[6, 7]
{
    {0, 0, 0, 0, 0, 0, 0}, 
    {0, 1, 0, 1, 1, 0, 0}, 
    {0, 1, 1, 1, 1, 1, 0}, 
    {0, 0, 1, 1, 1, 0, 0}, 
    {0, 1, 1, 0, 1, 0, 0}, 
    {0, 0, 0, 0, 0, 0, 0}
};

for (int i = 0; i < mapArray.GetLength(0); i++)
{
    for (int j = 0; j < mapArray.GetLength(1); j++)
    {
        if (mapArray[i, j] == 0)
        {
            Console.Write($" ");
        } else
        {
            Console.Write($"**");
        }
    }
    Console.WriteLine();
}

Console.ReadLine();