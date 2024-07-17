using CourseAPI.Dtos;
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NoOfChapters { get; set; }
        public string InstructorId { get; set; }
    }
}