public class HighSchoolStudent :Student
{
    public HighSchoolStudent(string email, string password) :base(email, password)
    {

    }
    public override float CalculateAverage()
    {
        float sumOfScores=0;
        float sumOfUnits=0;
        foreach(var studentCourse in base.Courses)
        {
            var course = (HighSchoolCourse)studentCourse._Course;
            sumOfScores += course.UnitOfCourse * studentCourse.Score;
            sumOfUnits += course.UnitOfCourse;
        }
        return sumOfScores/sumOfUnits;
    }
}
