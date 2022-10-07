public struct Coordinate
{
    public int X { get; }
    public int Y { get; }

    public Coordinate(int _x, int _y)
    {
        X = _x; Y = _y; 
    }

    public static bool adjacent(Coordinate a, Coordinate b)
    {
        int xChange = a.X - b.X;
        int yChange = a.Y - b.Y;

        if ((xChange <= a.X - 1) && (yChange == 0)) return true;
        if ((yChange <= a.Y - 1) && (xChange == 0)) return true;
        return false;
    }

}