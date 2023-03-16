namespace TheFountainOfObjects;

public class Fountain : IRooms
{
    public Location Location { get; set; }
    public bool OnStatus { get; set; } = false;

    public Fountain(Location location)
    {
        Location = location;
    }
}