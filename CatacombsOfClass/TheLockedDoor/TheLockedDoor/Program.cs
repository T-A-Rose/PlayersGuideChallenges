﻿using TheLockedDoor;

public class main
{   static public void Main(String[] args)
    {
        Console.WriteLine("Hello Adventurer, in order to pass through this door, you need to provide me with a starting passcode!");
        int PassCode = Convert.ToInt32(Console.ReadLine());
        Door door = new Door(PassCode);
        Console.Clear();

        InteractWithDoor(door);
        
    }

    private static void InteractWithDoor(Door door)
    {
        Console.WriteLine("If you want to unlock the door, you have to provide me with a passcode!");
        for (int i = 0; i < 5; i++)
        {
            int passcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you want to do with the door?");
            door.ChangeDoorState(passcode, Console.ReadLine());
        };
    }

}



