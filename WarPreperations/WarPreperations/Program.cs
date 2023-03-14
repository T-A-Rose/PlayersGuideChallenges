using WarPreperations;

List<Sword> listOfSwords = new();

var ironSword = new Sword(Materials.iron, Gemstone.none, 100, 25);
var bronzeSword = new Sword(Materials.bronze, Gemstone.emerald, 75, 10);
var steelSword = new Sword(Materials.steel, Gemstone.diamond, 125, 15);

creatingListOfSwords(ironSword);
creatingListOfSwords(bronzeSword);
creatingListOfSwords(steelSword);

List<Sword> creatingListOfSwords(Sword sword)
{
    listOfSwords.Add(sword);
    return listOfSwords;
}

foreach (var sword in listOfSwords)
{
    Console.WriteLine(sword.ToString());
}
Console.ReadLine();