using LibsForLesson20;

namespace Lesson20
{
    internal static class Program
    {
        private static void Main()
        {
            var ClassFromLib = new Class1 {Description = "Good bye" };
            Type classType = typeof(Class1);
            var properties = classType.GetProperties();
            var methods = classType.GetMethods();
            var fields = classType.GetFields();
            Console.WriteLine($"class name = {classType.Name}");
            foreach( var pr in properties ) 
            {
                Console.WriteLine($"property {pr.PropertyType.Name} {pr.Name}");
            }
            foreach( var meth in methods )
            {
                Console.WriteLine($"method {meth.ReturnType} {meth.Name}");
            }
            foreach (var field in fields)
            {
                Console.WriteLine($"field {field.FieldType.Name} {field.Name}");
            }
        }
    }
}