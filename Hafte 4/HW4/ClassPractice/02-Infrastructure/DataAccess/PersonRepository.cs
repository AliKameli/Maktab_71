public class PersonRepository : IPersonRepository
{
    public string Add(Person person)
    {
        var result = DataStore.People.FirstOrDefault(x=> x.SSID == person.SSID);
        if (result != null)
            return "This SSID exist for another person";
        DataStore.People.Add(person);
        DataStore.SaveFile();
        return "OK";
    }

    public string Delete(Person person)
    {
        var result = DataStore.People.FirstOrDefault(x=> x.SSID == person.SSID);
        if (result == null)
            return "This person does not exist";
        DataStore.People.Remove(person);
        return "OK";
    }

    public Person? Get(string sSID)
    {
        return DataStore.People.FirstOrDefault(x=> x.SSID == sSID);
    }

    public List<Person> GetAll()
    {
        return DataStore.People;
    }
    public void DeleteAll()
    {
        DataStore.People = new List<Person>();
    }
    public void SaveFile()
    {
        DataStore.SaveFile();
    }
}