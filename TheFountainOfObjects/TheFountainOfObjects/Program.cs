using TheFountainOfObjects;

var player = new Player();
//var cavernEntrance = new Location(0, 0);
var cavernEntrance = new CavernEntrance();


Console.WriteLine("Hello adventurer! Would you like to play a small, medium or large game?");
var play = GameSize();

Map GameSize() => Console.ReadLine().ToLower() switch
{
    "small" => new Map(4, 4),
    "medium" => new Map(6, 6),
    "large" => new Map(8, 8),
};

player.playerLocation = cavernEntrance;
Console.WriteLine("You find yourself at the cavern entrance of the Fountain of Objects");

do
{
    Console.WriteLine($"You are at Row={player.playerLocation.Row}, Column={player.playerLocation.Column}");
    player.isAlive = false;
} while (player.isAlive);

void checkLocation(Location currentLocation)
{
    
}
