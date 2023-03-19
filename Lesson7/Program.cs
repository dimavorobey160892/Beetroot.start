using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson7
{
    internal class Program
    {
        static string path = @"D:\Study in beetroot.academy\Homework\Beetroot.start\Lesson7\Phonebook.txt";
        enum Contact
        {
            FirstName = 0,
            LastName = 1,
            PhoneNumber = 2,
        }
        static void Main(string[] args)
        {            
            if (File.Exists(path))
            {
                //Console.WriteLine("File is exist...");
                var input = "";
                while (input != "EXIT")
                {
                    Console.Clear();
                    var phonebook = File.ReadAllLines(path);

                    WriteBook(phonebook);

                    Console.WriteLine("For search enter \"SEARCH\" ");
                    Console.WriteLine("For adding new contact enter \"ADD\"");
                    Console.WriteLine("For exit enter \"EXIT\" ");
                    input = Console.ReadLine();
                    if (input == "SEARCH")
                    {
                        Console.WriteLine(@"What criteries do you need to search...
                        0 = Fist name,
                        1 = Last name,
                        2 = Phone number");
                        var choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What do you need to search");
                        var search = Console.ReadLine();
                        var result = SearchBy(phonebook, search, (Contact)choice);
                        WriteBook(result.ToArray());
                        Console.ReadKey();

                    }
                    if (input == "ADD")
                    {
                        phonebook = AddNewContact(phonebook);
                        WriteBook(phonebook);
                        Console.ReadKey();

                    }

                }




            }
            else
            {
                Console.WriteLine("File isn't exist");
            }
        }

        static List<string> SearchBy(string[] phonebook, string search, Contact contact)
        {
            List<string> result = new List<string>();
            foreach (var line in phonebook)
            {
                var data = line.Split(" ");
                var dataSearch = data[(int)contact];
                if (Regex.IsMatch(dataSearch, search))
                {
                    result.Add(line);
                }
            }
            return result;
        }

        static void WriteBook(string[] book)
        {
            foreach (var contact in book)
            {
                Console.WriteLine(contact);
            }
        }

        static string[] AddNewContact(string[] phonebook)
        {
            Console.WriteLine("Enter First Name..");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name..");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber..");
            var phoneNumber = Console.ReadLine();
            phonebook = phonebook.Append($"{firstName} {lastName} {phoneNumber}").ToArray();
            File.WriteAllLines(path, phonebook);
            return phonebook;
        }



    }
}