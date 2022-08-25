using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLockedDoor
{
    internal  class Door
    {
        int doorPassCode = 1234;

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
                inputtedPasscode = Convert.ToInt32(Console.ReadLine());
                return (int)inputtedPasscode;
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
                    case "open":
                        if (DoorStatus == DoorState.locked && passcode == doorPassCode)
                        {
                            DoorStatus = DoorState.open;
                        } else
                        {
                            Console.WriteLine("That was an incorrect passcode, please try again");
                        }
                        break;
                    case "change passcode":
                        ChangeDoorPassCode(passcode);
                        break;
                }
        }
    }

    public enum DoorState { open, closed, locked }
}
