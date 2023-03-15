namespace ColoredItems;

public class ColoredItem<T>
{
    private ConsoleColor Color { get; }
    private T Weapon { get; }

    public ColoredItem(ConsoleColor _color, T _weapon)
    {
        Color = _color;
        Weapon = _weapon;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"A {Color} {Weapon}");
    }
    
}