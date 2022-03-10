public class Student :User
{
    public GradeEnum Grade { get; set; }
    public List<StudentCourse> Courses { get; set; }
    public Student(string email, string password):base(email,password,RoleEnum.Student)
    {
        Courses= new List<StudentCourse>();
    }
    public virtual float CalculateAverage()
    {       
       return Courses.Average(p => p.Score);
    }
    public override string ChangePassword(string pass)
    {
        if (pass.Length < 6)
            return "New Password Is Less Than 6 Characters.";
        base.Password=pass;
        return "OK";
    }
}
