// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

(int, Enum, Enum) food;
food = (7, ingredient.Vegetable, recipeTypes.Soup);
DisplayFood(food);

food = (3, ingredient.Cheese, recipeTypes.Pizza);
DisplayFood(food);

food = (3, ingredient.Meat, recipeTypes.Bread);
DisplayFood(food);

void DisplayFood((int, Enum, Enum) food)
{
    Console.WriteLine($"{food.Item1}-{food.Item2} {food.Item3}");
}

enum recipeTypes { Soup, Bread, Pizza};
enum ingredient { Cheese, Meat, Vegetable}