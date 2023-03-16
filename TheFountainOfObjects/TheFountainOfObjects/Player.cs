namespace TheFountainOfObjects;

public class Player
{
    public bool isAlive = true;
    public Location PlayerLocation { get; set; }

    public Player(Location playerLocation)
    {
        PlayerLocation = playerLocation;
    }
}