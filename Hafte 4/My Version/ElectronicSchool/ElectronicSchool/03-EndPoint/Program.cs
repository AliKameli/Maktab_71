
IUserRepository _userRepository = new UserRepository();
IStudentRepository _studentRepository = new StudentRepository();


User s = new Student("asdasd", "4654646464");
s.Mobile = "46546464";
((Student)s).Courses=new List<StudentCourse>() { new StudentCourse { Score=10} };


var currentuser = _userRepository.GetCurrentUser();
if (currentuser == null)
    LoginOrRegisterMenu();






void LoginOrRegisterMenu()
{
    Console.Clear();
    Console.WriteLine("------ Wellcome To Etectrinic School App--------");
    Console.WriteLine("L - Login");
    Console.WriteLine("R - Register");
    var inputKey = Console.ReadKey();
    if (inputKey.Key == ConsoleKey.L)
        Login();
    else if (inputKey.Key == ConsoleKey.R)
        Register();
    else
    {
        Console.WriteLine("You Press Invalid Key , Please Try Again.");
        Console.WriteLine("Please Enter Any Key To Continue .");
        Console.ReadKey();
        LoginOrRegisterMenu();
    }
}
void Login()
{
    Console.Clear();
    Console.WriteLine("------- Login -------------");
    Console.Write("Please Enter Your Email : ");
    var email = Console.ReadLine();
    if(email == null || email =="")
    {
        Console.WriteLine("Incorrect Email . Please Try Again .");
        Console.WriteLine("Please Enter Any Key To Continue.");
        Console.ReadKey();
        Login();
    }
    else
    {
        Console.WriteLine();
        Console.Write("Please Enter Your Password : ");
        var password = Console.ReadLine();
        if(password == null || password=="")
        {
            Console.WriteLine("Incorrect Password . Please Try Again .");
            Console.WriteLine("Please Enter Any Key To Continue.");
            Console.ReadKey();
            Login();
        }
        else
        {
            Console.WriteLine();
            var result = _userRepository.Login(email, password);
            if (result == "OK")
                MainMenu();
            else
            {
                Console.WriteLine(result);
                Console.WriteLine("Please Enter Any Key To Continue .");
                Console.ReadKey();
                LoginOrRegisterMenu();
            }
        }
        
    }
    
}
void Register()
{
    Console.Clear();
    Console.WriteLine("--------------- Register -----------");
    Console.Write("Please Enter Your Email : ");
    var email = Console.ReadLine();
    if(email is null || email=="")
    {
        Console.WriteLine("Incorrect Email Entered . Please Try Again.");
        Console.WriteLine("Please Enter Any Key To Continue .");
        Console.ReadKey();
        Register();
    }
    else
    {
        Console.WriteLine();
        Console.Write("Please Enter Your Password : ");
        var password = Console.ReadLine();
        if (password is null || password =="")
        {
            Console.WriteLine("Incorrect Password Entered . Please Try Again.");
            Console.WriteLine("Please Enter Any Key To Continue .");
            Console.ReadKey();
            Register();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{(int)RoleEnum.Student} - {RoleEnum.Student}");
            Console.WriteLine($"{(int)RoleEnum.Teacher} - {RoleEnum.Teacher}");
            Console.Write("Please Select Your Role : ");
            var roleId = Convert.ToInt32(Console.ReadLine());
            if (roleId != (int)RoleEnum.Student && roleId != (int)RoleEnum.Teacher)
            {
                Console.WriteLine("You Entered Incorrect Role. Please Try Again .");
                Console.WriteLine("Please Enter Any Key To Continue .");
                Console.ReadKey();
                Register();
            }
            var role = (RoleEnum)roleId;
            Console.WriteLine();
            Console.WriteLine($"{(int)GradeEnum.MiddleSchool} - {GradeEnum.MiddleSchool}");
            Console.WriteLine($"{(int)GradeEnum.HighSchool} - {GradeEnum.HighSchool}");
            Console.Write("Please Select Your Grade : ");
            var gradeId = Convert.ToInt32(Console.ReadLine());
            if (gradeId != (int)GradeEnum.MiddleSchool && gradeId != (int)GradeEnum.HighSchool)
            {
                Console.WriteLine("You Entered Incorrect Grade. Please Try Again .");
                Console.WriteLine("Please Enter Any Key To Continue .");
                Console.ReadKey();
                Register();
            }
            var grade = (GradeEnum)gradeId;

            User? newUser = null;

            switch (role)
            {
                case RoleEnum.Teacher:
                    switch (grade)
                    {
                        case GradeEnum.MiddleSchool:
                            break;
                        case GradeEnum.HighSchool:
                            break;
                    }
                    break;
                case RoleEnum.Student:
                    switch (grade)
                    {
                        case GradeEnum.MiddleSchool:

                            break;
                        case GradeEnum.HighSchool:
                            newUser = new HighSchoolStudent(email, password);
                            break;
                    }
                    break;
            }
            if(newUser is null)
            {
                Console.WriteLine("Registration Failed . Please Try Again .");
                Console.WriteLine("Please Enter Any Key To Continue .");
                Console.ReadKey();
                Register();
            }
            else
            {
                Console.WriteLine();
                Console.Write("Please Enter Your Name : ");
                newUser.Name = Console.ReadLine();
                Console.Write("Please Enter Your Mobile : ");
                newUser.Mobile = Console.ReadLine();
                _userRepository.RegisterUser(newUser);
                Console.WriteLine("Registration Is Successfull");
                Console.WriteLine("Please Enter Any Key To Continue .");
                Console.ReadKey();
                Login();
            }
            

        }



    }

}
void MainMenu()
{
    var currentUser = _userRepository.GetCurrentUser();
    if (currentUser == null)
        LoginOrRegisterMenu();
    else
    {
        
        switch (currentUser.Role)
        {
            case RoleEnum.Admin:
                AdminMenu();
                break;
            case RoleEnum.Teacher:
                break;
            case RoleEnum.Student:
                var currentStudent = (Student)currentUser;

                break;
            default:
                break;
        }
    }
    
}
void AdminMenu()
{
    var currentUser = _userRepository.GetCurrentUser();
    if (currentUser == null)
        LoginOrRegisterMenu();
    else
    {
        Console.Clear();
        Console.WriteLine("----------- Admin Menu ------------");
        Console.WriteLine($"Welcome {currentUser.Name}");
        var currentAdmin = (Admin)currentUser;
        Console.Clear();
        Console.WriteLine("L - List Of Users");
        Console.WriteLine("A - Activate User");
        Console.WriteLine("O - LogOff");
        Console.Write("Please Select Action : ");
        var inputKey = Console.ReadKey();
        switch (inputKey.Key)
        {
            case ConsoleKey.L:
                PrintListOfUser();
                break;
            case ConsoleKey.A:
                ActivateUser();
                break;
            case ConsoleKey.O:
                LogOff();
                break;
            default:
                break;
        }
    }
    
}
void LogOff()
{
    _userRepository.LogOff();
    LoginOrRegisterMenu();
}
void PrintListOfUser()
{
    var users = _userRepository.GetUsers();
    Console.Clear();
    Console.WriteLine("------------ List Of Users -------------");
    foreach (var user in users)
    {
        Console.WriteLine(user);
    }
    Console.WriteLine("Press Any key To Continue");
    Console.ReadKey();
    AdminMenu();
}
void ActivateUser()
{
    Console.Clear();
    Console.WriteLine("--------------- User Activation --------------");
    Console.Write("Please Enter User's Email : ");
    var email = Console.ReadLine();
    if (email == null)
    {
        Console.WriteLine("Invalid Email . Please Try Again .");
        Console.WriteLine("Please Enter Any Key To Continue .");
        Console.ReadKey();
        ActivateUser();
    }
    else
    {
        var user =_userRepository.GetUser(email);
        if (user == null)
        {
            Console.WriteLine("This User Dose Not Exist.");
            Console.WriteLine("Please Enter Any Key To Continue .");
            Console.ReadKey();
            ActivateUser();
        }
        else
        {
            user.Activate();
            Console.WriteLine("Success");
            Console.WriteLine("Please Enter Any Key To Continue .");
            Console.ReadKey();
            AdminMenu();
        }
            

        

    }
}



