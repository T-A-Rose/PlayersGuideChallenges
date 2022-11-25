// See https://aka.ms/new-console-template for more information
using VinsFletchersArrowsPart1__6th_Ed_;

Arrow obsidianArrow = new(75, ArrowHead.Obsidian, Fletching.TurkeyFeathers);
Arrow steelArrow = new(95, ArrowHead.Steel, Fletching.GooseFeathers);
DisplayArrow(obsidianArrow);
DisplayArrow(steelArrow);
Console.ReadLine();

void DisplayArrow(Arrow arrow)
{
    Console.WriteLine($"Length: {arrow.Length}cm");
    Console.WriteLine($"Fletching: {arrow.fletching}");
    Console.WriteLine($"Arrowhead: {arrow.arrowHead}");
    Console.WriteLine($"Cost: {arrow.GetCost()}gp\n");
}


