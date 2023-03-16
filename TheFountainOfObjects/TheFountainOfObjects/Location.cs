namespace TheFountainOfObjects;

public record Location
{
    public required int Row { get; set; }
    public required int Column { get; set; }

    public Location(int _row, int _column)
    {
        this.Row = _row;
        this.Column = _column;
    }
    
}