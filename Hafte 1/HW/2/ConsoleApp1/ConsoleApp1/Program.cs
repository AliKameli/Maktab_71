﻿Console.WriteLine("Hello . Welcome");
for (bool repeat = true; repeat == true;)
{
    OneOperator();

    for (bool inputIsValid = false; inputIsValid != true;)
    {
        Console.WriteLine("\ndo you want to repeat ?" + "\n" + "'y/n'");
        var t = (Console.ReadKey());
        if (t.Key == ConsoleKey.Y)
        {
            Console.Clear();
            inputIsValid = true;
        }
        else if (t.Key == ConsoleKey.N)
        {
            repeat = false;
            inputIsValid = true;
        }
        else
        {
            Console.WriteLine("\n" + "invalid input ! try again");
        }
    }
}
static List<int> GetNmbers(int lenght)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine($"Enter number {i + 1} of total {lenght}");
        int temporaryInputNumber = Convert.ToInt32(Console.ReadLine());
        numbers.Add(temporaryInputNumber);
    }
    return numbers;
}

static void OneOperator()
{
    int result = 0;
    Console.WriteLine("how many numbers ?" +
        " if you want to divide pls dont use 0 after the first number");
    var numbers = GetNmbers(Convert.ToInt32(Console.ReadLine()));
    ConsoleKeyInfo temporaryInputOperator = new ConsoleKeyInfo();
    Console.WriteLine("Enter operator ");
    temporaryInputOperator = Console.ReadKey();
    Console.WriteLine();
    if (temporaryInputOperator.Key is ConsoleKey.Add)
    {

        result = 0;
        foreach (int number in numbers)
            result += number;
    }
    else if (temporaryInputOperator.Key is ConsoleKey.Delete)
    {

        result = numbers[0];
        foreach (int number in numbers.Skip(1))
            result -= number;
    }
    else if (temporaryInputOperator.Key is ConsoleKey.Multiply)
    {

        result = 1;
        foreach (int number in numbers)
            result *= number;
    }
    else if (temporaryInputOperator.Key is ConsoleKey.Divide)
    {

        result = numbers[0];
        foreach (int number in numbers.Skip(1))
            result /= number;
    }
    else
    {
        Console.Write("Operator is invalid !");
        return;
    }
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        Console.Write($"{numbers[i]} {temporaryInputOperator.KeyChar} ");
        if (i == numbers.Count - 2)
        {
            Console.Write($"{numbers[i + 1]} = {result} \n");
        }
    }


    return;
}