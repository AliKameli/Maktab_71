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
static List<int> GetNumbarsAndSort(int lenght)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < lenght; i++)
    {
        Console.WriteLine($"Enter number {i + 1} of total {lenght}");
        int temporaryInputNumber = Convert.ToInt32(Console.ReadLine());
        if (i == 0)
            numbers.Add(temporaryInputNumber);
        for (int j = 0; j < i; j++)
        {
            if (numbers[j] < temporaryInputNumber)
            {
                numbers.Insert(j, temporaryInputNumber);
                j = i;
            }
            if (j == (i - 1))
                numbers.Add(temporaryInputNumber);
        }
    }
    return numbers;
}

static void OneOperator()
{
    int result = 0;
    Console.WriteLine("how many numbers ?");
    var numbers = GetNumbarsAndSort(Convert.ToInt32(Console.ReadLine()));
    List<int> pairs = new List<int>();
    Console.WriteLine("==========================");
    for (int i = 0; i < numbers.Count; i++)
    {

        switch (i % 2)
        {
            case 0:
                pairs.Add(numbers[i]);
                if (numbers.Count == 1)
                {
                    Console.Write($"{numbers[i]}");
                    continue;
                }
                if (i == numbers.Count - 1)
                {
                    Console.Write($" + {numbers[i]}");
                    continue;
                }
                if (i == 0)
                {
                    Console.Write($"({numbers[i]}");
                    continue;
                }
                Console.Write($" + ({numbers[i]}");
                break;
            case 1:
                switch ((pairs.Count - 1) % 4)
                {
                    case 0:
                        pairs[pairs.Count - 1] *= numbers[i];
                        Console.Write($" * {numbers[i]})");
                        break;
                    case 1:
                        pairs[pairs.Count - 1] /= numbers[i];
                        Console.Write($" / {numbers[i]})");
                        break;
                    case 2:
                        pairs[pairs.Count - 1] -= numbers[i];
                        Console.Write($" - {numbers[i]})");
                        break;
                    case 3:
                        pairs[pairs.Count - 1] += numbers[i];
                        Console.Write($" + {numbers[i]})");
                        break;
                }
                break;
        }

    }
    foreach (int pair in pairs)
        result += pair;
    Console.Write($" = {result}\n============\n");
    switch (result)
    {
        case > 0:
            Console.WriteLine("Valid");
            break;
        case 0:
            Console.WriteLine("The result is zero");
            break;
        case < 0:
            Console.WriteLine("Invalid");
            break;
    }
    return;
}