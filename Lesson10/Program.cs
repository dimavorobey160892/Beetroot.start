using SchoolLib;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School mySchool= new School();
            var firstClass = new Class { Name = "1A"};
            firstClass.AddPupil("Andryi", "Sichovyi", 6);
            firstClass.Teacher = new Teacher
                (
                "Sudorchuk",
                "Oleksandr",
                new Subject { Name = "Biology" }
                );
            firstClass.AddSchedule("Monday", new List<Subject>
            {
                new Subject { Name = "Biology" },
                new Subject { Name = "Physics"},
                new Subject { Name = "Ukrainian Language"}
            });

            firstClass.Teacher.UpdateInfo
                (
                "Sudorchuk",
                "Oleksandr",
                new Subject { Name = "Music" }
                );
            mySchool.AddClass(firstClass);

        }
    }
}