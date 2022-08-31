using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLockedDoor
{
    internal  class Door
    {
        int doorPassCode;

        public Door(int _doorPassCode)
        {
            doorPassCode = _doorPassCode;
        }

        public DoorState DoorStatus { get; set; } = DoorState.locked;

        private int ChangeDoorPassCode(int currentPasscode)
        {
            int? inputtedPasscode = 0;
            Console.WriteLine("Hello adventurer, in order to change the passcode of the door, you must first provide me with the current passcode to the door!");
            inputtedPasscode = Convert.ToInt32(Console.ReadLine());
            if (currentPasscode == inputtedPasscode)
            {
                Console.WriteLine("That passcode was correct, you must now set the new passcode you want!");
                doorPassCode = Convert.ToInt32(Console.ReadLine());
                return doorPassCode;
            }
            else
            {
                Console.WriteLine("That passcode is incorrect, you are denied from changing the passcode!");
            }
            return currentPasscode;
        }

        public void ChangeDoorState(int passcode, string userInput)
        {
                switch (userInput)
                {
                    case "close":
                        if (DoorStatus == DoorState.open) DoorStatus = DoorState.closed;
                        break;
                    case "lock":
                        if (DoorStatus == DoorState.closed) DoorStatus = DoorState.locked;
                        break;
                    case "unlock":
                        if (DoorStatus == DoorState.locked && passcode == doorPassCode)
                        {
                            DoorStatus = DoorState.unlocked;
                        } else
                        {
                            Console.WriteLine("That was an incorrect passcode, please try again");
                        }
                        break;
                    case "open":
                        if (DoorStatus == DoorState.unlocked) DoorStatus = DoorState.open;
                        break;
                    case "change passcode":
                        ChangeDoorPassCode(passcode);
                        break;
                }
            ReturnDoorStatus();
        }

        public void ReturnDoorStatus()
        {
            Console.WriteLine($"The door status is currently: {DoorStatus}");
        }

    }

    public enum DoorState { open, closed, locked, unlocked }
}
