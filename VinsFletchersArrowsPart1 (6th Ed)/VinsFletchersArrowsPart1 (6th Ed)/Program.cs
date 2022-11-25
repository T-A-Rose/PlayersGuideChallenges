// See https://aka.ms/new-console-template for more information
using VinsFletchersArrowsPart1__6th_Ed_;

Arrow arrow = new(75, ArrowHead.Obsidian, Fletching.TurkeyFeathers);
DisplayArrow(arrow);
Console.ReadLine();

void DisplayArrow(Arrow arrow)
{
    Console.WriteLine($"Length: {arrow.Length}cm");
    Console.WriteLine($"Fletching: {arrow.fletching}");
    Console.WriteLine($"Arrowhead: {arrow.arrowHead}");
    Console.WriteLine($"Cost: {arrow.GetCost()}gp");
}


