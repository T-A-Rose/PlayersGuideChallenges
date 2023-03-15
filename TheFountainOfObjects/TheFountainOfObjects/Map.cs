namespace TheFountainOfObjects;

public class Map
{
    public int[,] Rooms { get; set; }
    public int Row { get; }
    public int Column { get; }

    public Map(int _row, int _column)
    {
        Row = _row;
        Column = _column;
        
    }

    static void Movement(int row, int column)
    {
      
    }
    
}