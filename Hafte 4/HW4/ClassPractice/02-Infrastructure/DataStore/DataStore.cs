using System.Reflection;

public static class DataStore
{
    private static readonly string _dataStorFilePath = @"Data.json";
    public static List<Person> People { get; set; } = new List<Person>();
    static DataStore()
    {
        if (!File.Exists(_dataStorFilePath))
        {
            //File.Create(_dataStorFilePath);
            return;
        }
        //File.Decrypt(_dataStorFilePath);
        string[] fileReadString = File.ReadAllLines(_dataStorFilePath);
        foreach (string oneLineData in fileReadString)
        {
            string[] props = oneLineData.Split('\u002C');
            Person tempPerson = new Person(props[0], props[1], props[2], props[3], props[4], props[5], Int32.Parse(props[6]), Int32.Parse(props[7]), Int32.Parse(props[8]), Int32.Parse(props[9]));
            People.Add(tempPerson);
        }
    }
    public static void SaveFile()
    {
        List<string> fileWriteString = new List<string>();
        foreach (Person person in People)
        {
            List<string> propString = new List<string>();
            foreach (PropertyInfo propertyInfo in person.GetType().GetProperties())
            {
                propString.Add(propertyInfo.GetValue(person, null).ToString());
            }
            fileWriteString.Add(String.Join('\u002C', propString.ToArray()));
        }
        fileWriteString = fileWriteString.OrderBy(x => Convert.ToInt64(x.Split(',').First())).ToList();
        File.WriteAllLines(_dataStorFilePath, fileWriteString.ToArray());
        //File.Encrypt(_dataStorFilePath);
    }

}