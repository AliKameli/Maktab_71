using static EnumExtensions;

var enumTest = new ContactType();

//Writing names in enum
PrintEnum(enumTest);

//puting values of enum in an array
var enumNumbers = Enum.GetValues(typeof(ContactType));

//puting names of enum in an array
var enumNames = Enum.GetNames(typeof(ContactType));

//Writing Diplay names in enum
foreach (ContactType s in enumNumbers)
{
    Console.WriteLine(GetDisplayName(s));
}

//casting in to enum
ContactType castingTest = (ContactType)2;
Console.WriteLine(castingTest.ToString());

//writing numbers in enum
foreach (int i in enumNumbers)
{
    Console.WriteLine(i);
}

//connvering string to enum type
Console.WriteLine("Enter string to convet to enum");
string input = Console.ReadLine();
var inputEnum = input == "Red" ? ContactType.Email : ContactType.SMS;

//switch case
switch (inputEnum)
{
    case ContactType.Email:
        Console.WriteLine("is email");
        break;
    case ContactType.SMS:
        Console.WriteLine("is sms");
        break;
    default:
        break;
}