public abstract class Course
{
    public string Name { get; set; }
    public GradeEnum Grade { get; set; }
    public Teacher _Teacher { get; set; }


    protected Course(string name, GradeEnum grade, Teacher teacher)
    {
        Name = name;
        Grade = grade;
        _Teacher = teacher;
    }

    public override string? ToString()
    {
        return $" {this.Name} - Grade: {Grade} - Teacher: {_Teacher.Name }";
    }
}

