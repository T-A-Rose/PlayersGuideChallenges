using ThePoint;

public class temp
{
    static public void Main(String[] args)
    {
        Point point1 = new Point(2, 3);
        Console.WriteLine($"({point1._x}, {point1._y})");

        Point point2 = new Point(-4, 0);
        Console.WriteLine($"({point2._x}, {point2._y})");

        Point point3 = new Point();
        Console.WriteLine($"({point3._x}, {point3._y})");

        Console.ReadLine();
    }

}

