using CourseAPI.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GetCoursesDto> courses = [
    
        new (
            1,
            "Node Backend Development",
            "This is a demo course",
            20,
            "1"
        ),
        new (
            2,
            "React Development",
            "This is a Full course",
            10,
            "2"
        ),
        new (
            3,
            "Java with OOP Internship Bootcamp",
            "This is a Full course",
            20,
            "2"
        )
];
app.MapGet("courses", () => courses);

app.MapGet("/courses/{id:int}", (int id) =>
{
    var course = courses.FirstOrDefault(c => c.Id == id);
    if (course == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(course);
}).WithName("GetCourse");


app.MapPost("/courses", (CreateCourseDto newCourse) =>
{
    int id = courses.Count + 1;
    var course = new GetCoursesDto(id, newCourse.Name, newCourse.Description, newCourse.NoOfChapters, newCourse.InstructorId);

    courses.Add(course);

    return Results.CreatedAtRoute("GetCourse", new { id = id }, course);
});

app.Run();