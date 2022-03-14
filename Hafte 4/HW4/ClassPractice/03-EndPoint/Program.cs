using System.Reflection;
using static DataStore;
IPersonRepository _personRepository = new PersonRepository();

Console.WriteLine("Hello Welcome");
MainMenu();

void MainMenu()
{
    Console.Clear();
    Console.WriteLine(" --------------------- Main Menu --------------------- ");
    Console.WriteLine("Select one :");
    Console.WriteLine("1 - Add Person");
    Console.WriteLine("2 - Show List Of Saved People");
    Console.WriteLine("3 - Save Data To File");
    Console.WriteLine("4 - Delete All Data");
    Console.WriteLine("5 - Exit");

    var inputSelectMenu = Console.ReadKey(true);
    switch (inputSelectMenu.Key)
    {
        case (ConsoleKey.NumPad1):
        case (ConsoleKey.D1):
            AddPersonMenu();
            break;
        case (ConsoleKey.D2):
        case (ConsoleKey.NumPad2):
            ShowPersonList();
            break;
        case (ConsoleKey.D3):
        case (ConsoleKey.NumPad3):
            _personRepository.SaveFile();
            Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
            Console.WriteLine("All Data Saved !!!\n");
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            MainMenu();
            break;
        case (ConsoleKey.D4):
        case (ConsoleKey.NumPad4):
            _personRepository.DeleteAll();
            Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
            Console.WriteLine("All Data Deleted !!!\n");
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            MainMenu();
            break;
        case (ConsoleKey.D5):
        case (ConsoleKey.NumPad5):
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Wrong Input Try Again \nPress Any Key To Conti");
            Console.ReadKey();
            MainMenu();
            break;
    }
    return;
}

void AddPersonMenu()
{
    Console.Clear();
    Console.WriteLine(" --------------------- Add Menu --------------------- ");
    Console.WriteLine("Enter Your SSID");
    var personSSID = Console.ReadLine();
    if (!Int64.TryParse(personSSID,out _))
    {
        Console.WriteLine("Invalid SSID");
        MainMenu();
        return;
    }
    Person person = new Person(personSSID);
    Console.WriteLine("Enter Your MobileNumber");
    var personMobile=Console.ReadLine();
    if (!Int64.TryParse(personMobile, out _))
    {
        Console.WriteLine("Invalid SSID");
        MainMenu();
        return;
    }
    person.Mobile = personMobile;
    foreach (PropertyInfo propertyInfo in person.GetType().GetProperties())
    {
        if (propertyInfo.Name == "SSID"||propertyInfo.Name=="Mobile")
            continue;
        Console.WriteLine($"Enter Your {propertyInfo.Name}");
        ;
        if (propertyInfo.PropertyType == typeof(string))
        {
            var input = Console.ReadLine();
            propertyInfo.SetValue(person, input, null);
        }
        if (propertyInfo.PropertyType == typeof(int))
        {
            var input = Console.ReadLine();
            bool temp = Int32.TryParse(input, out int personNumberTemp);
            if (!temp)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
                MainMenu();
                return;
            }

            propertyInfo.SetValue(person, personNumberTemp, null);
        }
    }
    var result = _personRepository.Add(person);
    if (result == "OK")
        Console.WriteLine("Person Added Successfully !");
    else
        Console.WriteLine(result);
    Console.WriteLine("Press Any Key To Continue");
    Console.ReadKey();
    MainMenu();
    return;
}
void ShowPersonList()
{
    Console.Clear();
    Console.WriteLine(" --------------------- List --------------------- ");
    foreach (Person person in _personRepository.GetAll())
    {
        Console.WriteLine(person);
    }
    Console.WriteLine(" --------------------- END --------------------- ");
    Console.WriteLine("Press Any Key To Continue");
    Console.ReadKey();
    MainMenu();
    return;
}