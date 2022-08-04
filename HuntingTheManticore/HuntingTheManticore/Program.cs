int manticoreHealth = 10;
int cityHealth = 15;
int rounds = 1;
int range = 0;
int cannonDamage = 0;
while (manticoreHealth > 0)
{
    range = ManticoresDistanceFromCity();
    Console.Clear();
    Console.WriteLine($"There has currently been {rounds} round played. The City currently has {cityHealth} health and the Manticore has {manticoreHealth} left!");
    cannonDamage = CalculateCannonDamage(rounds);
    TargetRangeFromPlayerTwo(range, cannonDamage);

};

int ManticoresDistanceFromCity()
{
    int range = 0;
    Console.WriteLine("Player 1, how far away is the Manticore from the city, between 0 - 100?");
    range = Convert.ToInt32(Console.ReadLine());
    if (range >= 0 && range <= 100)
    {
        return range;
    } else
    {
        return 0;
    }
}

int CalculateCannonDamage(int roundNo)
{
    if (roundNo % 3 == 0)
    {
        Console.WriteLine("The Cannon will deal 3 fire blast damage to the Manticore!");
        return 3;
    } else if (roundNo % 5 == 0)
    {
        Console.WriteLine("The Cannon will deal 3 electric blast damage to the Manticore!");
        return 3;
    } else if ((roundNo % 3 == 0) && (roundNo % 5 == 0))
    {
        Console.WriteLine("The Cannon will deal 10 fire-electric blast damage to the Manticore!");
        return 10;
    } else
    {
        return 1;
    }
}

int TargetRangeFromPlayerTwo(int manticoreRange, int cannonDamage)
{
    Console.WriteLine("Player 2, please enter the desired cannon range, between 0 - 100");
    int targetRange = Convert.ToInt32(Console.ReadLine());
    if (targetRange == manticoreRange)
    {
        manticoreHealth = manticoreHealth - cannonDamage;
        Console.WriteLine($"DIRECT HIT on the Manticore for a total of {cannonDamage}!");
        if (manticoreHealth == 0)
        {
            Console.Write(" The Manticore has been destroyed! The city of Consolas is saved!");
        }
        return manticoreHealth;
    } else if (targetRange < manticoreRange)
    {
        Console.WriteLine("Damn, you undershot the target!");
        return manticoreHealth;
    } else if (targetRange > manticoreRange)
    {
        Console.WriteLine("Damn, you overshot the target!");
        return manticoreHealth;
    }
    return manticoreRange;
}
