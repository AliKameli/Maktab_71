struct Food
{
    public string Name { get; }
    public int Calorie { get; }
    public int RemainingCount { get; set; }
    public Food(string name, int calorie, int count = 0)
    {
        Name = name;
        Calorie = calorie;
        RemainingCount = count;
    }
}