const string OutOfBoundsFailureMessage = "That wasn't between the boundaries, please enter a value between 0 - 100!";

int manticoreHealth = 10;
int cityHealth = 15;
int rounds = 1;

while (manticoreHealth > 0)
{
    int manticoresDistance = getManticoresDistanceFromCity();

    GameIO.Reset();

    GameIO.WriteToOutput($"The City currently has {cityHealth} health and the Manticore has {manticoreHealth} left!");

    var cannonDamage = calculateCannonDamage(rounds);

    Result manticoreHealthResult = new FailureResult();

    using (GameIO.WithColour(cannonDamage.DamageType.GetConsoleColour()))
    {
        GameIO.WriteToOutput($"The Cannon will deal {cannonDamage.Value} {cannonDamage.DamageTypeName} damage to the Manticore!");

        manticoreHealthResult = getAttemptToHitManticore(manticoreHealth, manticoresDistance, cannonDamage.Value);
    }

    if (manticoreHealthResult is SuccessResult<int> successResult)
    {
        manticoreHealth = successResult.Value;
    }
    
    if (manticoreHealth <= 0)
    {
        GameIO.WriteToOutput("The Manticore has been destroyed! The city of Consolas is saved!");

        break;
    }

    if (cityHealth < 2)
    {
        GameIO.WriteToOutput("The city of Consolas has been destroyed, we didn't destroy the Manticore in time!");

        break;
    }

    GameIO.WriteToOutput($"There has currently been {rounds++} round played.");
};

Console.ReadLine();


int getManticoresDistanceFromCity()
{
    GameIO.WriteToOutput("Player 1, how far away is the Manticore from the city, between 0 - 100?");

    var range = GameIO.GetUserInput((string input, out int range) => int.TryParse(input, out range) && range >= 0 && range <= 100, OutOfBoundsFailureMessage);

    return range;
}

Result getAttemptToHitManticore(int currentManticoreHealth, int manticoreRange, int cannonDamage)
{
    GameIO.WriteToOutput("Player 2, please enter the desired cannon range, between 0 - 100");

    var targetRange = GameIO.GetUserInput((string x, out int range) => int.TryParse(x, out range) && range > 0 && range < 100, OutOfBoundsFailureMessage);

    if (targetRange < manticoreRange)
    {
        GameIO.WriteToOutput("Damn, you undershot the target!");

        return new FailureResult();
    }
    if (targetRange > manticoreRange)
    {
        GameIO.WriteToOutput("Damn, you overshot the target!");

        return new FailureResult();
    }

    var resultantManticoreHealth = currentManticoreHealth - cannonDamage;

    GameIO.WriteToOutput($"DIRECT HIT on the Manticore for a total of {cannonDamage}!");

    return new SuccessResult<int>(resultantManticoreHealth);
}

// FYI, this is the fizz-buzz interview problem that everyone talks about
Damage calculateCannonDamage(int roundNo)
{
    if ((roundNo % 3 == 0) && (roundNo % 5 == 0)) return new(10, DamageType.FIRE_ELECTRIC_BLAST);
    
    if (roundNo % 5 == 0) return new(3, DamageType.ELECTRIC_BLAST);
    
    if (roundNo % 3 == 0) return new(3, DamageType.FIRE_BLAST); 
    
    return new(1, DamageType.STANDARD);
}

public delegate bool TryParse<TIn, TOut>(TIn input, out TOut output);

public class GameIO
{
    public static void WriteToOutput(string message) => Console.WriteLine(message);

    public static IDisposable WithColour(ConsoleColor colour)
    {
        _currentOptions = new Options(colour);
        return _currentOptions;
    }

    private static Options? _currentOptions;

    private class Options : IDisposable
    {
        private readonly ConsoleColor _colourCache;

        public Options(ConsoleColor colour)
        {
            _colourCache = Console.ForegroundColor;
            Console.ForegroundColor = colour;
        }

        public void Dispose()
        {
            Console.ForegroundColor = _colourCache;
        }
    }

    public static string GetUserInput(Predicate<string> isInputValid, string messageOnFailure)
    {
        while (true)
        {
            var input = Console.ReadLine() ?? string.Empty;

            if (isInputValid(input)) return input;

            Console.WriteLine(messageOnFailure);
        }
    }
    
    public static T GetUserInput<T>(TryParse<string, T> isInputValid, string messageOnFailure)
    {
        while (true)
        {
            var input = Console.ReadLine() ?? string.Empty;

            if (isInputValid(input, out T output)) return output;

            Console.WriteLine(messageOnFailure);
        }
    }

    public static void Reset()
    {
        _currentOptions?.Dispose();
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
    }
}

public abstract record Result;

public record SuccessResult<T>(T Value) : Result;

public record FailureResult() : Result;

public record Damage(int Value, DamageType DamageType)
{
    public string DamageTypeName => DamageType switch
    {
        DamageType.FIRE_ELECTRIC_BLAST => "fire-electric blast",
        DamageType.ELECTRIC_BLAST => "electric blast",
        DamageType.FIRE_BLAST => "fire blast",
        DamageType.STANDARD => "standard",
        _ => throw new ArgumentException(nameof(DamageType)),
    };
}

public enum DamageType
{
    FIRE_ELECTRIC_BLAST,
    ELECTRIC_BLAST,
    FIRE_BLAST,
    STANDARD
}

public static class DamageTypeConsoleColourExtensions
{
    public static ConsoleColor GetConsoleColour(this DamageType damageType) => damageType switch
    {
        DamageType.FIRE_ELECTRIC_BLAST => ConsoleColor.Magenta,
        DamageType.ELECTRIC_BLAST => ConsoleColor.Yellow,
        DamageType.FIRE_BLAST => ConsoleColor.Red,
        DamageType.STANDARD => ConsoleColor.White,
        _ => ConsoleColor.White,
    };
}


