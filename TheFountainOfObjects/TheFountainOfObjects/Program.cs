using TheFountainOfObjects;
using System.Linq;
using System.ComponentModel;

var player = new Player();
//var cavernEntrance = new Location(0, 0);
var cavernEntrance = new CavernEntrance(new Location(0, 0));
var fountainRoom = new Fountain(new Location(0, 2));

Console.WriteLine("Hello adventurer! Would you like to play a small, medium or large game?");
var mapSize = GameSize();

Map GameSize() => Console.ReadLine().ToLower() switch
{
    "small" => new Map(new int[4,4]),
    "medium" => new Map(new int[6,6]),
    "large" => new Map(new int[8,8]),
};

player.playerLocation = cavernEntrance.Location;
var playerLocY = player.playerLocation.row;
var playerLocX = player.playerLocation.column;
Console.WriteLine("You find yourself at the cavern entrance of the Fountain of Objects");

do
{
    Console.WriteLine($"You are in the room at (Row={playerLocY}, Column={playerLocX})");
    ValidLocation();
    if (player.playerLocation == fountainRoom.Location && fountainRoom.OnStatus == true)
    {
        Console.WriteLine("You win!");
    }
} while (player.isAlive);


void ValidLocation()
{
    var direction = Console.ReadLine().ToLower();
    ConfirmValidGridLoc(direction);
}

void ConfirmValidGridLoc(string direction)
{
    var test = (int)Math.Sqrt(mapSize.MapCoordindates.Length);
    if (direction == "move east" && (playerLocX >= 0 && (playerLocX + 1) <= test))
    {
        player.playerLocation = new Location(playerLocY, playerLocX += 1);
        return;
    } 
    if (direction == "move west" && ((playerLocX - 1) >= 0 && playerLocX <= test))
    {
        player.playerLocation = new Location(playerLocY, playerLocX -= 1);
        return;
    }
    if (direction == "move south" && (playerLocY >= 0 && (playerLocY + 1) <= test))
    {
        player.playerLocation = new Location(playerLocY + 1, playerLocX);
    }
    if (direction == "move north" && ((playerLocY - 1) >= 0 && playerLocY <= test))
    {
        player.playerLocation = new Location(playerLocY - 1, playerLocX);
    }



    //} else if ((direction == "move west") && ((playerLocX + 1) >= 0 && playerLocX <= mapSize.MapCoordindates.Length / test))
    //{
    //    player.playerLocation = new Location(playerLocY, playerLocX -= 1);
    if ((direction == "move north") && (playerLocY < 0 || (playerLocY - 1) > mapSize.MapCoordindates.Length / test))
    {
        player.playerLocation = new Location(playerLocY -= 1, playerLocY);

    } else
    {
        player.playerLocation = new Location(playerLocY += 1, playerLocY);
    }
    //} else if ((direction == "move south") && ((playerLocY + 1) < 0 || playerLocY > mapSize.MapCoordindates.Length / test))
    //{
    //    player.playerLocation = new Location(playerLocY += 1, playerLocY);
    //}
}

