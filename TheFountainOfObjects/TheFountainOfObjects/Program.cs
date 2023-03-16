using TheFountainOfObjects;

var player = new Player();
//var cavernEntrance = new Location(0, 0);
var cavernEntrance = new CavernEntrance(new Location(0, 0));
var fountainRoom = new Fountain(new Location(0, 2));

Console.WriteLine("Hello adventurer! Would you like to play a small, medium or large game?");
var play = GameSize();

Map GameSize() => Console.ReadLine().ToLower() switch
{
    "small" => new Map(new int[4,4]),
    "medium" => new Map(new int[6,6]),
    "large" => new Map(new int[8,8]),
};

player.playerLocation = cavernEntrance.Location;
var playerLocRow = player.playerLocation.row;
var playerLocCol = player.playerLocation.column;
Console.WriteLine("You find yourself at the cavern entrance of the Fountain of Objects");

do
{
    Console.WriteLine($"You are in the room at (Row={player.playerLocation.row}, Column={player.playerLocation.column})");
    checkLocation();
    if (player.playerLocation == fountainRoom.Location && fountainRoom.OnStatus == true)
    {
        Console.WriteLine("You win!");
    }
} while (player.isAlive);

void checkLocation()
{
    Console.WriteLine("Where would you like to go?");
    var temp = Console.ReadLine() switch
    {
        "Move east" => ValidLocation("Move east"),
        "Move west" => ValidLocation("Move west"),
        "Move north" => ValidLocation("Move north"),
        "Move south" => ValidLocation("Move south"),
        _ => "Incorrect instruction, please try again"
    };
}

string ValidLocation(string direction)
{
    if (direction == "Move east")
    {
        player.playerLocation = new Location(playerLocRow, playerLocCol += 1);
    }
    ConfirmValidGridLoc(play, player);

    return "";
}

void ConfirmValidGridLoc(Map map, Player player1)
{
    for (var i = 0; i < map.MapCoordindates.Length; i++)
    {
        if (player1.playerLocation.row > i)
        {
            Console.WriteLine("You're unable to go that far!");
        }
    }
}

