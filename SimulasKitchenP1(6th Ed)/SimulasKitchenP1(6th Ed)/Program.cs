// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

(int Number, Enum Ingredient, Enum Base) food;
food = (7, ingredient.Vegetable, recipeTypes.Soup);
DisplayFood(food);

food = (3, ingredient.Cheese, recipeTypes.Pizza);
DisplayFood(food);

food = (3, ingredient.Meat, recipeTypes.Bread);
DisplayFood(food);

PickFood();
Console.ReadLine();

void DisplayFood((int Number, Enum Ingredient, Enum Base) food)
{
    Console.WriteLine($"{food.Number}-{food.Ingredient} {food.Base}");
}

void PickFood(){
    Console.WriteLine("Hello again adventurer, I need you to pick a number between 1-5 to decide what food you'll receive");
    food = Convert.ToInt16(Console.ReadLine()) switch
    {
        1 => food = (7, ingredient.Vegetable, recipeTypes.Soup),
        2 => food = (3, ingredient.Cheese, recipeTypes.Pizza),
        3 => food = (0, ingredient.Meat, recipeTypes.Pizza),
        4 => food = (6, ingredient.Cheese, recipeTypes.Bread),
        5 => food = (5, ingredient.Meat, recipeTypes.Soup),
        _ => default
    };
    DisplayFood(food);
}

enum recipeTypes { Soup, Bread, Pizza};
enum ingredient { Cheese, Meat, Vegetable}