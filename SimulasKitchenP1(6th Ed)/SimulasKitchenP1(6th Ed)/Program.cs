// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

(int Number, Enum Ingredient, Enum Base) food;
food = (7, ingredient.Vegetable, recipeTypes.Soup);
DisplayFood(food);

food = (3, ingredient.Cheese, recipeTypes.Pizza);
DisplayFood(food);

food = (3, ingredient.Meat, recipeTypes.Bread);
DisplayFood(food);

void DisplayFood((int Number, Enum Ingredient, Enum Base) food)
{
    Console.WriteLine($"{food.Number}-{food.Ingredient} {food.Base}");
}

enum recipeTypes { Soup, Bread, Pizza};
enum ingredient { Cheese, Meat, Vegetable}