namespace TheFountainOfObjects;

public class Pit : IRooms
{
    public Location Location { get; set; }

    public Pit(Location location)
    {
        Location = location;
    }
}