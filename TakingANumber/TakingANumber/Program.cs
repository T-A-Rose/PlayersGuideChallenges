// See https://aka.ms/new-console-template for more information

int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
int rangeOfSwallow = AskForNumberInRange("What is the flight range of the swallow?", 1, 100);
Console.ReadLine();

int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    Console.WriteLine(text);
    int userInput = Convert.ToInt32(Console.ReadLine());
    
    while (userInput is not 0)
    {
        if (userInput >= min && userInput <= max)
        {
            return userInput;
        } else
        {
            userInput = AskForNumber("That number wasn't between the acceptable ranges, please enter another");
        } 
    }
    return 0;
}
