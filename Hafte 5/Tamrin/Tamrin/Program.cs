Console.WriteLine("enter string");

string input = Console.ReadLine();

TryPList(input);
TryP(input);

void TryPList(string input)
{
    List<int> leftP = new List<int>();
    List<int> rightP = new List<int>();
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] =='(')
            leftP.Add(i);
        if (input[i] ==')')
            rightP.Add(i);
    }
    if (leftP.Count != rightP.Count)
    {
        Console.WriteLine("Not OK");
        return;
    }
    leftP.Sort();
    rightP.Sort();
    //rightP.Reverse();
    for (int i = 0; i < leftP.Count; i++)
    {
        if (leftP[i] > rightP[i])
        {
            Console.WriteLine("Not OK");
            return ;
        }
    }
    Console.WriteLine("OK");

}

void TryP(string input)
{
    int pCount = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '(')
            pCount++;
        if (input[i] == ')')
            pCount--;
        if (pCount < 0)
        {
            Console.WriteLine("Not OK");
            break;
        }
    }
    if (pCount == 0)
        Console.WriteLine("OK");
}
interface IRepos<T>
{
    T Get(int id);
    int Add(T item);
    int Remove(T item);
}
class PersonRepo<T> : IRepos<T>
{
    public int Add(T item)
    {
        throw new NotImplementedException();
    }

    public T Get(int id)
    {
        throw new NotImplementedException();
    }

    public int Remove(T item)
    {
        throw new NotImplementedException();
    }
}