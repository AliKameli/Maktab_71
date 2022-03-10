public static class DataStore
{
    public static List<User> Users { get; set; }
    public static User? CurrentUser { get; set; }
    public static List<Course> Courses { get; set; }

    static DataStore()
    {
        Users = new List<User>();
        var admin = new Admin("ali", "123");
        admin.Activate();
        Users.Add(admin);
        var teacher = new Teacher("amin", "123");
        teacher.Activate();
        Users.Add(teacher);
        CurrentUser =null;
        Courses = new List<Course>();
    }
}
