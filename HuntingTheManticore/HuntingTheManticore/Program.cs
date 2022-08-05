int manticoreHealth = 10;
int cityHealth = 15;
int rounds = 1;
int range = -1;
int targetRange = -1;
int cannonDamage = 0;
while (manticoreHealth > 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    ManticoresDistanceFromCity();
    Console.Clear();
    Console.WriteLine($"The City currently has { cityHealth} health and the Manticore has { manticoreHealth} left!");
    cannonDamage = CalculateCannonDamage(rounds);
    TargetRangeFromPlayerTwo(range, cannonDamage);
    Console.ForegroundColor = ConsoleColor.White;
    
    if  (manticoreHealth > 0 && cityHealth > 0)
    {
        cityHealth -= 1;
        if (cityHealth <= 0)
        {
            Console.WriteLine("The city of Consolas has been destoyed, we didn't destroy the Manticore in time!");
            Console.ReadLine();
            break;
        }
    } else if (manticoreHealth <= 0)
    {
        Console.Write(" The Manticore has been destroyed! The city of Consolas is saved!");
        Console.ReadLine();
        break;
    }
    Console.WriteLine($"There has currently been {rounds} round played.");
    rounds++;
};

void ManticoresDistanceFromCity()
{
    Console.WriteLine("Player 1, how far away is the Manticore from the city, between 0 - 100?");

    //do
    //{
    //    range = Convert.ToInt32(Console.ReadLine());
    //    if (range < 0 || range > 100)
    //        Console.WriteLine("That wasn't between the boundaries, please enter a value between 0 - 100!");
    //} while (range < 0 || range > 100);

    while (true)
    {
        range = Convert.ToInt32(Console.ReadLine());
        if (range >= 0 && range <= 100) break;
        Console.WriteLine("That wasn't between the boundaries, please enter a value between 0 - 100!");
    };
}

void TargetRangeFromPlayerTwo(int manticoreRange, int cannonDamage)
{
    Console.WriteLine("Player 2, please enter the desired cannon range, between 0 - 100");
    do
    {
        targetRange = Convert.ToInt32(Console.ReadLine());
        if (targetRange == manticoreRange)
        {
            manticoreHealth = manticoreHealth - cannonDamage;
            Console.WriteLine($"DIRECT HIT on the Manticore for a total of {cannonDamage}!");
            break;
        }
        else if (targetRange < manticoreRange && targetRange > 0)
        {
            Console.WriteLine("Damn, you undershot the target!");
            break;
        }
        else if (targetRange > manticoreRange && targetRange < 100)
        {
            Console.WriteLine("Damn, you overshot the target!");
            break;
        }
        Console.WriteLine("That wasn't between the boundaries, please enter a value between 0 - 100!");
    } while (targetRange < 0 || targetRange > 100);
}

int CalculateCannonDamage(int roundNo)
{
    if ((roundNo % 3 == 0) && (roundNo % 5 == 0))
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("The Cannon will deal 10 fire-electric blast damage to the Manticore!");
        return 10;
    } 
    if (roundNo % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The Cannon will deal 3 electric blast damage to the Manticore!");
        return 3;
    } 
    if (roundNo % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The Cannon will deal 3 fire blast damage to the Manticore!");
        return 3;
    } 
        Console.WriteLine("The Cannon will deal 1 damage to the Manticore!");
        return 1;
}


