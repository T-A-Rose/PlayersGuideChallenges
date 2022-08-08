// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Chest lockState = Chest.Closed;
string chestState = "";
while (true)
{
    Console.WriteLine($"The chest is currently {lockState}, please enter a command to change the state");
    chestState = Console.ReadLine().ToLower();
    switch (chestState)
    {
        case "close":
            if (lockState == Chest.Open) lockState = Chest.Closed;
            break;
        case "lock":
            if (lockState == Chest.Closed) lockState = Chest.Locked;            
            break;
        case "unlock":
            if (lockState == Chest.Locked) lockState = Chest.Closed;
            break;
        case "open":
            if (lockState == Chest.Closed) lockState = Chest.Open;
                break;
        default:
            Console.WriteLine("You've entered an invalid command, please enter a different input");
            break;
    }
};

enum Chest { Open, Closed, Locked };