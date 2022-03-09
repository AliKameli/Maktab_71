//Main
{
    Console.WriteLine("Hello. Welcome");
    Console.WriteLine("Enter number of rows");
    int x = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter number of culomns");
    int y = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter maximum number in matris");
    int z = Int32.Parse(Console.ReadLine());
    var matris = CreateMatris(x, y, z + 1);
    Console.WriteLine("\nThe matris is :\n");
    PrintMatris(matris);
    Console.WriteLine("\nThe SORTED matris is :\n");
    PrintMatris(HalazoonSortMatris(matris));
    Console.ReadKey();
}
int[,] CreateMatris(int x, int y, int max)
{
    Random r = new Random();
    int[,] result = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            result[i, j] = r.Next(max);
        }
    }
    return result;
}
void PrintMatris(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        Console.Write("\n|\t");
        for (int j = 0; j < mat.GetLength(1); j++)
        {
                Console.Write(mat[i, j] + "\t");
        }
        
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr)
{
    int[] result = new int[arr.Length];
    //Creating new array so the first array stays intact
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    int n = result.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (result[j] > result[j + 1])
            {
                // swap temp and arr[i]
                int temp = result[j];
                result[j] = result[j + 1];
                result[j + 1] = temp;
            }
    return result;
}
int[,] HalazoonSortMatris(int[,] mat)
{
    int x = mat.GetLength(0);
    int y = mat.GetLength(1);
    int[,] result = new int[x, y];
    int[] sortedNumbers = new int[x * y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            sortedNumbers[i * y + j] = mat[i, j];
        }
    }
    sortedNumbers = SortArray(sortedNumbers);
    InsertRows(result, sortedNumbers, 0, 0);
    return result;

}
void InsertRows(int[,] mat, int[] numbers, int numbersStart, int insertedBefor)
{
    int newNumbersStart = numbersStart;
    if (newNumbersStart == numbers.Length)
        return;
    for (int j = insertedBefor; j < mat.GetLength(1) - insertedBefor; j++)
    {
        mat[insertedBefor, j] = numbers[newNumbersStart];
        newNumbersStart++;
    }
    if (newNumbersStart == numbers.Length)
        return;
    for (int i = insertedBefor + 1; i < mat.GetLength(0) - insertedBefor - 1; i++)
    {
        mat[i, mat.GetLength(1) - insertedBefor - 1] = numbers[newNumbersStart];
        newNumbersStart++;
    }
    if (newNumbersStart == numbers.Length)
        return;
    for (int j = mat.GetLength(1) - insertedBefor - 1; j >= insertedBefor; j--)
    {
        mat[mat.GetLength(0) - insertedBefor - 1, j] = numbers[newNumbersStart];
        newNumbersStart++;
    }
    if (newNumbersStart == numbers.Length)
        return;
    for (int i = mat.GetLength(0) - insertedBefor - 2; i > insertedBefor; i--)
    {
        mat[i, insertedBefor] = numbers[newNumbersStart];
        newNumbersStart++;
    }
    if (newNumbersStart == numbers.Length)
        return;
    InsertRows(mat, numbers, newNumbersStart, insertedBefor + 1);
}