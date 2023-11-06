using AutoMapper;
using HW1_AutoMapperExampleUsage.Models;

/*
 * AutoMapper: A C# library to map data between objects, it transforms one object to another
 * inputObj -> AutoMapper -> outputObj
 * In real time projects, it can be used between view model classes and model classes
 * Pros and cons:
 * Reduces code repetition and allows the developer to create custom mapping
 * But on the otherhand, it creates performance overhead compared with manual object mapping
 */

/*Scenario 1: two objects with same field names*/
Console.WriteLine("Scenario 1: Mapping two differnt objects with same field names");

var config = new MapperConfiguration(cfg =>

    cfg.CreateMap<Course, CourseDTO>());

//source obj
Course course = new Course()
{
    Id = 1,
    Name = "Introduction to Computer Science",
    CourseCode = "CS101"
};

Console.WriteLine("Mapping input object type: " + course.GetType().Name);
Console.WriteLine("Mapping input object: " + course);

//mapping
var mapper = new Mapper(config);
var courseDTO = mapper.Map<CourseDTO>(course);

Console.WriteLine("Mapping output object type: " + courseDTO.GetType().Name);
Console.WriteLine("Mapping output object: " + courseDTO);




/*Scenario 2: two objects with different field names*/
Console.WriteLine("\nScenario 2: Mapping two different objects with different field names");

var configTwo = new MapperConfiguration(cfg =>

        cfg.CreateMap<Student, StudentDTO>()

        .ForMember(dest => dest.StudentId, act => act.MapFrom(src => src.Id))

        .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.Surname)));

//source obj 
Student student = new Student()
{
    Id = 1,
    Name = "StudentName",
    Surname = "StudentSurname",
    Age = 22

}; 

Console.WriteLine("Mapping input object type: " + student.GetType().Name);
Console.WriteLine("Mapping input object: " + student);

//mapping
var mapperTwo = new Mapper(configTwo);
var studentDTO = mapperTwo.Map<StudentDTO>(student);

Console.WriteLine("Mapping output object type: " + studentDTO.GetType().Name);
Console.WriteLine("Mapping output object: " + studentDTO);