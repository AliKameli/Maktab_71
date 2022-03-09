class Person
{
    private string _name;
    private byte _age;
    private short _weight;
    private short _height;
    private bool _isMale;
    private short _dailyMaxCalorie;
    private short _consumedCalorie;
    public string Name { get { return _name; } }
    public int Age { get { return (int)_age; } }
    public int Weight { get { return (int)_weight; } }
    public int Height { get { return (int)_height; } }
    public string Gender
    {
        get
        {
            if (_isMale)
                return "Male";
            else
                return "Female";
        }
    }
    public int DailyMaxCalorie { get { return (int)_dailyMaxCalorie; } }
    public int ConsumedCalorie { get { return (int)_consumedCalorie; } }
    public Person(string name, int age, int weight, int height, string gender)
    {
        _name = name;
        _age = (byte)age;
        _weight = (short)weight;
        _height = (short)height;
        short maxCalorieConst = 5;
        if (gender == "male" || gender == "Male")
        {
            _isMale = true;
        }
        else
        {
            _isMale = false;
            maxCalorieConst = -161;
        }
        _dailyMaxCalorie = (short)((10 * weight) + (6.25 * height) - (5 * age) + maxCalorieConst);
        _consumedCalorie = 0;
    }
    public bool EatCalorie(int calorie)
    {
        int remainingDailyCalorie = _dailyMaxCalorie - _consumedCalorie;
        if (calorie > remainingDailyCalorie)
        {
            Console.WriteLine("too much calorie for today");
            return false;
        }
        else
        {
            _consumedCalorie += (short)calorie;
            Console.WriteLine("Noosh jan");
            return true;
        }
    }
}