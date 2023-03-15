using ColoredItems;

ColoredItem<Sword> sword = new ColoredItem<Sword>(ConsoleColor.Blue, new Sword());
ColoredItem<Bow> bow = new ColoredItem<Bow>(ConsoleColor.Red, new Bow());
ColoredItem<Axe> axe = new ColoredItem<Axe>(ConsoleColor.Green, new Axe());

sword.Display();
bow.Display();
axe.Display();

public class Sword{}
public class Bow{}
public class Axe{}