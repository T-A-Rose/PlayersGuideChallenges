using TheFountainOfObjects;

var player = new Player(new(0, 0));
//var cavernEntrance = new Location(0, 0);
var cavernEntrance = new CavernEntrance(new(0,0));


Console.WriteLine("Hello adventurer! Would you like to play a small, medium or large game?");
var play = GameSize();

Map GameSize() => Console.ReadLine().ToLower() switch
{
    "small" => new Map(4, 4),
    "medium" => new Map(6, 6),
    "large" => new Map(8, 8),
};

player.PlayerLocation = cavernEntrance.Location;
Console.WriteLine("You find yourself at the cavern entrance of the Fountain of Objects");

do
{
    Console.WriteLine($"You are at Row={player.PlayerLocation.Row}, Column={player.PlayerLocation.Column}");
    player.isAlive = false;
} while (player.isAlive);

void checkLocation(Location currentLocation)
{
    
}
