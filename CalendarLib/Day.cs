using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLib
{
    public class Day
    {
        public int Id { get; set; }
        public List<string> Meetings { get; set; }
        public Day(int id)
        {
            Id = id;
            Meetings = new List<string>();
        }

        public void PrintDay()
        {
            Console.WriteLine($"{Id}");
            if ( Meetings != null && Meetings.Count > 0)
            {
                Console.WriteLine("Meetings:");
                foreach (var meeting in Meetings)
                {
                    Console.WriteLine(meeting);
                }
            }
            else 
            {
                Console.WriteLine("No meetings"); 
            }
            
        }
    }
}
