// See https://aka.ms/new-console-template for more information
using ArrowFactories;

Console.WriteLine("Hello adventurer! Welcome to Vin's Arrows!");
Console.WriteLine("Here we make bespoke custom arrows of your own design, or we can make you some pre-designed arrows, which would you like?");

ArrowHeadType SelectArrowhead()
{
    Console.WriteLine($"The options for arrow head are as follows {ArrowHeadType.steel}, {ArrowHeadType.wood} & finally {ArrowHeadType.obsidian}!");

    string chosenArrowhead = Console.ReadLine().ToLower();
    return chosenArrowhead switch
    {
        "steel" => ArrowHeadType.steel,
        "wood" => ArrowHeadType.wood,
        "obsidian" => ArrowHeadType.obsidian,
        _ => ArrowHeadType.steel
    };
}

ArrowFletchingType SelectArrowFletching()
{
    Console.WriteLine("What fletching would you like to go with that?");
    Console.WriteLine($"The options are as follows: {ArrowFletchingType.plastic}, {ArrowFletchingType.turkeyfeathers} & finally {ArrowFletchingType.goosefeathers}!");

    string chosenArrowfletching = Console.ReadLine().ToLower();
    switch (chosenArrowfletching)
    {
        case "plastic": return ArrowFletchingType.plastic;
        case "turkey feathers": return ArrowFletchingType.turkeyfeathers;
        case "goose feathers": return ArrowFletchingType.goosefeathers;
        default: return ArrowFletchingType.plastic;
    }
}

float SetArrowLength()
{
    Console.WriteLine("Now, we just need the length of the arrow you want!");
    return Convert.ToInt32(Console.ReadLine());
}

void DisplayCost(Arrow arrow)
{
    Console.WriteLine($"The cost for that arrow will be {arrow.GetCost} gold pieces!");
}

string bespokeOrCustom = Console.ReadLine().ToLower();

if (bespokeOrCustom == "custom")
{
    DisplayCost(new Arrow(SelectArrowhead(), SelectArrowFletching(), SetArrowLength()));
} else
{
    Console.WriteLine("Your pre-designed options are as follows: Elite Arrow, Beginner Arrow or finally Marksmen Arrow");
    string chosenPreDesigned = Console.ReadLine().ToLower();
    Arrow arrow = chosenPreDesigned switch
    {
        "elite arrow" => Arrow.CreateEliteArrow(),
        "beginner arrow" => Arrow.CreateEliteArrow(),
        "marksmen arrow" => Arrow.CreateMarksmenArrow(),
        _ => Arrow.CreateEliteArrow()
    };
    DisplayCost(arrow);
}

Console.ReadLine();

