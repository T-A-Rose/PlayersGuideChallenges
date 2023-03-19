namespace TheFountainOfObjects;

public class Map
{
    public int[,] Rooms { get; set; }
    public int[,] MapCoordindates { get; }
    
    public Map(int[,] mapCoordinates)
    {
        MapCoordindates = mapCoordinates;
    }   
}