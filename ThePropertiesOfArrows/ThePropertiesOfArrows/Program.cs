// See https://aka.ms/new-console-template for more information
using VinFletchersArrows;

ArrowHeadType arrowHT = SelectArrowhead();
ArrowFletchingType arrowFT = SelectArrowFletching();
float arrowLength = SetArrowLength();

ArrowHeadType SelectArrowhead()
{
    Console.WriteLine("Hello adventurer! Welcome to Vin's Arrows!");
    Console.WriteLine("Here we make bespoke arrows custom to your own desires, so tell me, what type of arrow would you like?");
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
    Console.WriteLine($"That's great, now you've selected {arrowHT}, what fletching would you like to go with that?");
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
    return arrowLength = Convert.ToInt32(Console.ReadLine());
}

Arrow designedArrow = new Arrow(arrowHT, arrowFT, arrowLength);

Console.WriteLine($"The cost for that arrow will be {designedArrow.GetCost} gold pieces!");

Console.ReadLine();

