public class HighSchoolCourse : Course
{

    public int UnitOfCourse { get; set; }
    public HighSchoolCourse(string name, GradeEnum grade, Teacher teacher, int unitOfCourse) : base(name, grade, teacher)
    {
        UnitOfCourse = unitOfCourse;
    }
    public override string? ToString()
    {
        return $" {this.Name} - Grade: {Grade} - Unit: {UnitOfCourse} - Teacher: {_Teacher.Name }";
    }
}

