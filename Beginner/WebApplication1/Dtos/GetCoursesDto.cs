using CourseAPI.Dtos;

 public class GetCoursesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NoOfChapters { get; set; }
        public string InstructorId { get; set; }

        public GetCoursesDto(int id, string name, string description, int noOfChapters, string instructorId)
        {
            Id = id;
            Name = name;
            Description = description;
            NoOfChapters = noOfChapters;
            InstructorId = instructorId;
        }
    }