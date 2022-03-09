Console.WriteLine("Hello . Welcome");
Console.WriteLine("Enter first string");
string firstInput = Console.ReadLine();
Console.WriteLine("Enter second string");
string secondInput = Console.ReadLine();
Console.WriteLine($"\nLargest substring is : {LargestSubString(firstInput, secondInput)}");
string LargestSubString(string a, string b)
{
    List<List<char>> temp = new List<List<char>>();
    int wordNum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < b.Length; j++)
        {
            if (a[i] == b[j])
            {
                temp.Add(new List<char>());
                for (int k = i, z = j; k < a.Length && z < b.Length; k++, z++)
                {
                    if (a[k] == b[z])
                    {
                        temp[wordNum].Add(a[k]);
                    }
                    else
                    {
                        wordNum++;
                        j = z;
                        break;
                    }
                }
            }
        }
    }
    int resultIndex = 0;
    for (int i = 0; i < temp.Count; i++)
    {
        if (temp[i].Count() > temp[resultIndex].Count())
            resultIndex = i;
    }
    var result = new string(temp[resultIndex].ToArray());
    return result;
}