using CalendarLib;
using System.Text.Json;

namespace Lesson21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var RoomList = new List<Calendar>();
            var input = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Hello Calendar!");
                Console.WriteLine("To close program enter - 0");
                Console.WriteLine("Choose mode:");
                Console.WriteLine("1 - readonly");
                Console.WriteLine("2 - RW");
                Console.WriteLine("3 - Load calendars");
                Console.WriteLine("4 - Save calendars");
                input = Console.ReadLine();
                string choice = "";
                if (input == "1" || input == "2")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Hello Calendar!");
                        Console.WriteLine("To change mode enter - 0");

                        Console.WriteLine("1 - View Roomlist");
                        Console.WriteLine("2 - View Room");
                        Console.WriteLine("3 - View meetings");

                        if (input == "2")
                        {
                            Console.WriteLine("4 - Add Room");
                            Console.WriteLine("5 - Add Meeting");
                        }

                        choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                ViewRoomList(RoomList);
                                break;
                            case "2":
                                ViewRoom(RoomList);
                                break;
                            case "3":
                                ViewMeetings(RoomList);
                                break;
                            case "4":
                                if (input == "2")
                                {
                                    AddRoom(ref RoomList);
                                }
                                break;
                            case "5":
                                if (input == "2")
                                {
                                    AddMeetings(ref RoomList);
                                }
                                break;
                        }
                        Console.ReadKey();
                    } while (choice != "0");
                }
                if (input == "3")
                {
                    string json = File.ReadAllText(@".\roomlist.txt");
                    if (json.Length > 0)
                    {
                        var options = new JsonSerializerOptions { IncludeFields = true };
                        RoomList =
                        JsonSerializer.Deserialize<List<Calendar>>(json, options);
                    }
                }
                if (input == "4")
                {
                    var options = new JsonSerializerOptions { IncludeFields = true };
                    var json = JsonSerializer.Serialize(RoomList, options);
                    File.WriteAllText(@".\roomlist.txt", json);
                }

            } while (input != "0");

        }
        public static void ViewRoomList(List<Calendar> list)
        {
            foreach (Calendar c in list)
            {
                Console.WriteLine($"{c.Id}. {c.Name}, {c.Year}");
            }
        }
        public static void ViewRoom(List<Calendar> calendars)
        {
            Console.WriteLine("Enter room ID");
            var id = Convert.ToInt32(Console.ReadLine());
            calendars.FirstOrDefault(c => c.Id == id)?.PrintCalendar();
        }

        public static void ViewMeetings(List<Calendar> calendars)
        {
            Console.WriteLine("Enter room ID");
            var id = Convert.ToInt32(Console.ReadLine());
            calendars.FirstOrDefault(c => c.Id == id)?.ShowMeetings();
        }

        public static void AddRoom(ref List<Calendar> calendars)
        {
            Console.WriteLine("Enter room name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter year");
            var year = Convert.ToInt32(Console.ReadLine());
            calendars.Add(new Calendar { Name = name, Year = year });
        }

        public static void AddMeetings(ref List<Calendar> calendars)
        {
            Console.WriteLine("Enter room ID");
            var id = Convert.ToInt32(Console.ReadLine());
            calendars.FirstOrDefault(c => c.Id == id)?.AddMeeting();
        }


    }
}