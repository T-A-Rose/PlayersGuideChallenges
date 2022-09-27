using TheLockedDoor;

public class main
{   static public void Main(String[] args)
    {
        Console.WriteLine("Hello Adventurer, in order to pass through this door, you need to provide me with a starting passcode!");
        int PassCode = Convert.ToInt32(Console.ReadLine());
        Door door = new(PassCode);
        Console.Clear();

        InteractWithDoor(door, PassCode);
        
    }

    private static void InteractWithDoor(Door door, int passcode)
    {

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("What do you want to do with the door?");
            string? doorCommand = Console.ReadLine().ToLower();
            if (doorCommand == "unlock")
            {
                Console.WriteLine("If you want to do that, you have to provide me with a passcode!");
                passcode = Convert.ToInt32(Console.ReadLine());
            }
            door.ChangeDoorState(passcode, doorCommand);
        };
    }

}




