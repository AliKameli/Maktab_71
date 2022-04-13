var people = new List<Person>();
for (int z = 0; z < 100; z++)
{
    people.Add(new Person() { Id=z,Name=z.ToString(),Age=z,Address=z.ToString()});
    people.Add(new Person() { Id = z, Name = z.ToString(), Age = z, Address = z.ToString() });

}
people[50].Address = "Tehran";
people[51].Address = "Tehran";
people[52].Address = "Tehran";

var a = people.Where(x=> x.Age>20).OrderBy(x=> x.Name).ToList();
var b = people.Where(x=> x.BirthDate<new DateTime(1999,1,1)).ToList();
var c = people.GroupBy(x=>x.BirthDate).ToList();
var d = people.OrderBy(x => x.Id).ToList()[3];
var e = people.OrderBy(x=>x.Id).ToList().Take(new Range(50,80)).ToList();
var f = people.Where(x=> x.Age==people.Max(y=> y.Age)).ToList();
var g = people.GroupBy(x=> x.Id).ToList();
var h = people.Where(x=> x.Address.Contains("Tehran")).ToList();
var i = h.GroupBy(x=>x.Name).ToList().Where(x=>x.Count()>=2).ToList(); 
var j = people.Where(x=> x.SSID.ToString().Contains("123")).ToList();
var k = people.Where(x=>x.Age>25).ToList().Select(x=> new {x.Address,x.SSID}).ToList();
Console.ReadKey();