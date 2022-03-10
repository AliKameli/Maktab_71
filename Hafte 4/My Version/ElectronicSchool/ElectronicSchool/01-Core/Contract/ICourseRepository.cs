interface ICourseRepository
{
    List<Course> GetCourses();
    string AddCourse(Course course);
}