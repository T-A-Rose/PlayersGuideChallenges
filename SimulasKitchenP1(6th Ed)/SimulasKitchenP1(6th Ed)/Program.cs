// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

(int, string, string) food;
food = (7, "-", "Vegetable Soup");
DisplayFood(food);

food = (3, "-", "Cheese Pizza");
DisplayFood(food);

void DisplayFood((int, string, string) food)
{
    Console.WriteLine($"{food.Item1}{food.Item2}{food.Item3}");
}