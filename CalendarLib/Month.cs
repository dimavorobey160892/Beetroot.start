using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLib
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List <Day> Days { get; set; }
        public Month(int id, string name, int DaysCount)
        {
            Id = id;
            Name = name;
            Days = new List<Day>();
            for (int i = 1; i <= DaysCount; i++) 
            {
                Days.Add(new Day(i));
            }
        }

        public void PrintMonth()
        {
            Console.WriteLine($"{Name}");
            foreach (Day day in Days)
            {
                day.PrintDay();
            }

        }



    }
}
