using TheFountainOfObjects;

var player = new Player();
var cavernEntrance = new CavernEntrance(new Location(0, 0));
var pit = new Pit(new Location(3, 2));
var fountainRoom = new Fountain(new Location(0, 2));

Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Hello adventurer! Would you like to play a small, medium or large game?");
var mapSize = GameSize();

Map GameSize() => Console.ReadLine().ToLower() switch
{
    "small" => new Map(new int[4,4]),
    "medium" => new Map(new int[6,6]),
    "large" => new Map(new int[8,8]),
    _=> new Map(new int[4,4])
};

player.playerLocation = cavernEntrance.Location;
var playerLocY = player.playerLocation.row;
var playerLocX = player.playerLocation.column;
Console.WriteLine("You find yourself at the cavern entrance of the Fountain of Objects");

do
{
    GenerateMessage();
    if (fountainRoom.OnStatus && player.playerLocation == cavernEntrance.Location)
    {
        Console.WriteLine("The Fountain of Objects has been re-activated, and you have escaped with your life!");
        Console.WriteLine("You win!");
        break;
    }
} while (player.isAlive);


void GetCommand()
{
    if (fountainRoom.OnStatus != true || player.playerLocation != cavernEntrance.Location)
    {
        Console.WriteLine($"You are in the room at (Row={playerLocY}, Column={playerLocX})");
        Console.Write("What do you want to do? ");
    }
    var instruction = Console.ReadLine().ToLower();
    ConfirmValidGridLoc(instruction);
}

void ConfirmValidGridLoc(string command)
{
    var gridEnd = (int)Math.Sqrt(mapSize.MapCoordindates.Length);
    if (command == "move east" && (playerLocX >= 0 && (playerLocX + 1) <= gridEnd))
    {
        player.playerLocation = new Location(playerLocY, playerLocX += 1);
        return;
    } 
    if (command == "move west" && ((playerLocX - 1) >= 0 && playerLocX <= gridEnd))
    {
        player.playerLocation = new Location(playerLocY, playerLocX -= 1);
        return;
    }
    if (command == "move south" && (playerLocY >= 0 && (playerLocY + 1) <= gridEnd))
    {
        player.playerLocation = new Location(playerLocY += 1, playerLocX);
        return;
    }
    if (command == "move north" && ((playerLocY - 1) >= 0 && playerLocY <= gridEnd))
    {
        player.playerLocation = new Location(playerLocY -= 1, playerLocX);
    }
    if (command == "enable fountain")
    {
        Console.WriteLine("You successfully activate the Fountain of Objects, now try to find the exit!");
        fountainRoom.OnStatus = true;
    }
}

void GenerateMessage()
{
    GetCommand();
    if (player.playerLocation == pit.Location)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You go to step into a dark room, only to lose your footing and fall into a giant pit!");
        player.isAlive = false;
    } else if (player.playerLocation == fountainRoom.Location && fountainRoom.OnStatus == false)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
        Console.WriteLine("The fountain must be enabled before you can leave, to do this type in " +
                          "'enable fountain' exactly!");
    } else if (player.playerLocation == cavernEntrance.Location && fountainRoom.OnStatus == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return;
    }
}