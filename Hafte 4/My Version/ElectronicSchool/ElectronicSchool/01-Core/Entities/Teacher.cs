public class Teacher : User
{
    public Teacher(string email, string password) : base(email, password, RoleEnum.Teacher)
    {
        
    }
    public override string ChangePassword(string pass)
    {
        if (pass.Length < 8)
            return "New Password Is Less Than 8 Characters.";
        base.Password = pass;
        return "OK";
    }
}