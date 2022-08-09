using VinFletchersArrows;

for (int i = 1; i <= 5; i++)
{
    Arrow arrow = new();
    Console.WriteLine($"For that bespoke arrow, you're looking at {arrow.GetCost()} gold pieces!");
}

Console.ReadLine();


