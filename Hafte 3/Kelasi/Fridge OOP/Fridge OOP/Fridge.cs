class Fridge
{
    private string _name;
    private List<Food> _foodList;
    private bool _doorIsOpen = false;
    public string Name { get { return _name; } }
    public List<Food> FoodList { get { return _foodList; } }
    public bool DoorIsOpen { get { return _doorIsOpen; } }
    public Fridge(string name)
    {
        _name = name;
        _foodList = new List<Food>();
    }
    public Fridge(string name, List<Food> foodList)
    {
        _name = name;
        _foodList = new List<Food>(foodList);
    }
    private int GetFoodIndexByName(string name)
    {
        int foodIndexInList = -1;
        for (int i = 0; i < _foodList.Count; i++)
        {
            if (_foodList[i].Name == name)
            {
                foodIndexInList = i;
                break;
            }
        }
        return foodIndexInList;
    }
    public void OpenDoor()
    {
        if (_doorIsOpen)
        {
            Console.WriteLine("Door is already open !");
            return;
        }

        _doorIsOpen = true;
        Console.WriteLine("Door opened !");
    }
    public void CloseDoor()
    {
        if (!_doorIsOpen)
        {
            Console.WriteLine("Door is already closed !");
            return;
        }

        _doorIsOpen = false;
        Console.WriteLine("Door closed !");
    }
    public bool AddNewFood(string foodName, int foodCalorie, int count = 0)
    {
        if (!_doorIsOpen)
        {
            Console.WriteLine("Door is closed ! Open the door first .");
            return false;
        }
        if (GetFoodIndexByName(foodName) != -1)
        {
            Console.WriteLine($"{foodName} already exist ! Try adding Old food");
            return false;
        }

        Food newFood = new Food(foodName, foodCalorie, count);
        _foodList.Add(newFood);

        Console.WriteLine("New food added !");
        return true;
    }
    public bool AddOldFood(string foodName, int addCount)
    {
        if (!_doorIsOpen)
        {
            Console.WriteLine("Door is closed ! Open the door first .");
            return false;
        }
        int foodIndexInList = GetFoodIndexByName(foodName);

        if (foodIndexInList == -1)
        {
            Console.WriteLine("This type of food doesnt exist . Try adding New food .");
            return false;
        }

        Food tempFood = _foodList[foodIndexInList];
        tempFood.RemainingCount += addCount;
        _foodList[foodIndexInList] = tempFood;

        Console.WriteLine("Old food added !");
        return true;
    }

    /// <returns>true if food got out;
    /// false if food didnt get out;</returns>
    public bool GetFood(string foodName, int foodWantedCount = 1)
    {
        if (!_doorIsOpen)
        {
            Console.WriteLine("Door is closed ! Open the door first .");
            return false;
        }
        int foodIndexInList = GetFoodIndexByName(foodName);
        if (foodIndexInList == -1)
        {
            Console.WriteLine("Food type doesnt exist !");
            return false;
        }
        if (_foodList[foodIndexInList].RemainingCount < foodWantedCount)
        {
            Console.WriteLine("Not enough food left !");
            return false;
        }

        Food tempFood = _foodList[foodIndexInList];
        tempFood.RemainingCount -= foodWantedCount;
        _foodList[foodIndexInList] = tempFood;
        Console.WriteLine("Food is out boss .");
        return true;
    }
    public void PrintFoodList()
    {
        Console.Write($"{"#"}\t{"FoodName"}\t{"RemainingCount"}\n");
        for (int i = 0; i < _foodList.Count; i++)
        {
            Console.Write($"{i}\t{_foodList[i].Name}\t\t{_foodList[i].RemainingCount}\n");
        }
        Console.WriteLine("==========================================================================");
    }

}