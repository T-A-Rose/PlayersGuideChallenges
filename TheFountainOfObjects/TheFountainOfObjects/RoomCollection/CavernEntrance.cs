namespace TheFountainOfObjects;

public class CavernEntrance : IRooms
{
    public Location Location { get; set; }

    public CavernEntrance(Location location)
    {
        Location = location;
    }
}