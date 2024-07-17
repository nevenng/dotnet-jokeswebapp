using CourseAPI.Dtos;

 public class GetCoursesDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Category { get; set; }

        public GetCoursesDto(int id, string title, string description, int duration, string category)
        {
            Id = id;
            Title = title;
            Description = description;
            Duration = duration;
            Category = category;
        }
    }