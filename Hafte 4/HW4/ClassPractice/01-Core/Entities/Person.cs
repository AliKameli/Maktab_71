using System.Collections;

public class Person
{
    public string SSID { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FatherName { get; set; }
    public string Mobile { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public int BirthDate { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }


    public Person(string sSID, string firstName = "", string lastName = "")
    {
        SSID = sSID;
        FatherName = firstName;
        LastName = lastName;
    }

    public Person(string sSID, string firstName, string lastName, string fatherName, string mobile, string address, int age, int birthDate, int height, int weight)
    {
        SSID = sSID;
        FirstName = firstName;
        LastName = lastName;
        FatherName = fatherName;
        Age = age;
        BirthDate = birthDate;
        Height = height;
        Weight = weight;
        Mobile = mobile;
        Address = address;
    }
    public override string ToString()
    {
        return $"FirstName : {FirstName}\nLastName : {LastName}\nSSID : {SSID}\n-----------";
    }
}