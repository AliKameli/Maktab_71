Getnumbers();


int[] Getnumbers()
{
    Console.WriteLine("please enter interger array split by space :");
    var input = Console.ReadLine();
    List<string> result = new List<string>();
    result.Add(new string(""));
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            result.Add(new string(""));
            continue;
        }
        else
        {
            result[result.Count - 1] = result[result.Count - 1].Insert(result[result.Count - 1].Length, input[i].ToString());
        }
    }
    List<int> intResult = new List<int>();
    Console.WriteLine("result array is :\n");
    for (int i = 0; i < result.Count; i++)
    {
        Console.Write(result[i] + " - ");
        intResult.Add(Int32.Parse(result[i]));
    }
    return intResult.ToArray();
}