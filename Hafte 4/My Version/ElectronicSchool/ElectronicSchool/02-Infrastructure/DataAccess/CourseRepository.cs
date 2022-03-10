internal class CourseRepository : ICourseRepository
{
    public string AddCourse(Course course)
    {
        if (DataStore.Courses.Any(u => u.Name == course.Name&&u._Teacher==course._Teacher))
            return "This course already exists";
        DataStore.Courses.Add(course);
        return "OK";
    }

    public List<Course> GetCourses()
    {
        return DataStore.Courses;
    }
}