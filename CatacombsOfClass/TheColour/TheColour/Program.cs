using TheColour;

Color firstColor = new Color(254, 54, 3);
Color secondColor = Color.Orange;
DisplayColorVals(firstColor);
DisplayColorVals(secondColor);
Console.ReadLine();

void DisplayColorVals(Color color)
{
    Console.WriteLine($"({color.RedValue}, {color.GreenValue}, {color.BlueValue})");
};

//THIS DOESN'T WORK, BUT I'M NOT SURE WHY, CAN ANYONE EXPLAIN?
Console.WriteLine(secondColor);