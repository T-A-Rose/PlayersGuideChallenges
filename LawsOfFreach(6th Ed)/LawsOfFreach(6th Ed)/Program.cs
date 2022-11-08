int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currLowestAmt = int.MaxValue;
int totalSum = 0;
foreach (int i in array)
{
    totalSum += i;
    if (i < currLowestAmt)
    {
        currLowestAmt = i;
    }
}

float average = (float)totalSum / array.Length;

Console.WriteLine($"Lowest amount of the array: {currLowestAmt}\n");

Console.WriteLine($"Average amount of the array: {average}");
Console.ReadLine();
