
countdown(10);

int countdown(int number)
{
    Console.WriteLine(number);
    if (number == 1) return 1;
    return number - countdown(number - 1);
};

Console.ReadLine();