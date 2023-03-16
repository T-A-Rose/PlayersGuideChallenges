namespace TheFountainOfObjects;

public class Map
{
    public int[,] Rooms { get; set; }
    private int Row { get; }
    private int Column { get; }
    public int[,] MapCoordindates { get; }
    
    public Map(int[,] mapCoordinates)
    {
        MapCoordindates = mapCoordinates;
    }
    static void Movement(int row, int column)
    {
      
    }
    
}