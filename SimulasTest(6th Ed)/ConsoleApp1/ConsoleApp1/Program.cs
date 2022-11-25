// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Adventurer, you come across a chest, this test can be Open, Closed, Locked or Unlocked.");
ChestState chestState = ChestState.Locked;

while (true)
{
    Console.WriteLine("Please enter what you want to do with the box!");

    switch (Console.ReadLine().ToLower())
    {
        case "unlock":
            if (chestState == ChestState.Locked) chestState = ChestState.Unlocked;
            break;
        case "open":
            if (chestState == ChestState.Unlocked) chestState = ChestState.Open;
            break;
        case "close":
            if (chestState == ChestState.Open) chestState = ChestState.Closed;
            break;
        case "lock":
            if (chestState == ChestState.Closed || chestState == ChestState.Unlocked) chestState = ChestState.Locked;
            break;
        default:
            break;
    }
    Console.WriteLine($"The state of the chest is {chestState}");
}

enum ChestState { Open, Closed, Locked, Unlocked};
