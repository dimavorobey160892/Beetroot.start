namespace CalendarLib
{
    public class Calendar
    {
        private int _id;
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Month> Monthes { get; set; }
        private static int Count;
        public int Id { get { return _id; } }

        private enum MonthEnum
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        private Dictionary<MonthEnum, int> MonthDays;

        static Calendar()
        {
            Count = 0;
        }

        public Calendar()
        {
            MonthDays = new Dictionary<MonthEnum, int>
            {
                { MonthEnum.January, 31 },
                { MonthEnum.February, 28 },
                { MonthEnum.March, 31 },
                { MonthEnum.April, 30 },
                { MonthEnum.May, 31 },
                { MonthEnum.June, 30 },
                { MonthEnum.July, 31 },
                { MonthEnum.August, 231 },
                { MonthEnum.September, 30 },
                { MonthEnum.October, 31 },
                { MonthEnum.November, 30 },
                { MonthEnum.December, 31 }
            };

            Monthes = new List<Month>
            {
                new Month((int)MonthEnum.January, "January", MonthDays[MonthEnum.January]),
                new Month((int)MonthEnum.February, "February", MonthDays[MonthEnum.February]),
                new Month((int)MonthEnum.March, "March", MonthDays[MonthEnum.March]),
                new Month((int)MonthEnum.April, "April", MonthDays[MonthEnum.April]),
                new Month((int)MonthEnum.May, "May", MonthDays[MonthEnum.May]),
                new Month((int)MonthEnum.June, "June", MonthDays[MonthEnum.June]),
                new Month((int)MonthEnum.July, "July", MonthDays[MonthEnum.July]),
                new Month((int)MonthEnum.August, "August", MonthDays[MonthEnum.August]),
                new Month((int)MonthEnum.September, "September", MonthDays[MonthEnum.September]),
                new Month((int)MonthEnum.October, "October", MonthDays[MonthEnum.October]),
                new Month((int)MonthEnum.November, "November", MonthDays[MonthEnum.November]),
                new Month((int)MonthEnum.December, "December", MonthDays[MonthEnum.December])
            };

            _id = ++Count;
        }

        public void PrintCalendar()
        {
            Console.WriteLine($"Calendar id= {_id}, Name: {Name}");
            if (Monthes != null && Monthes.Count > 0)
            {
                foreach ( Month month in Monthes )
                {
                    month.PrintMonth();
                }
            }
            else
            {
                Console.WriteLine("No monthes");
            }

        }

        public void AddMeeting()
        {
            Console.WriteLine("Adding meeting");
            Console.WriteLine("Enter a numer of month");
            var monthNumber = Convert.ToInt32(Console.ReadLine());
            if (monthNumber > 0 && monthNumber <13)
            {
                var maxDays = MonthDays[(MonthEnum)monthNumber];
                Console.WriteLine($" Enter day from 1 to {maxDays}");
                var day = Convert.ToInt32(Console.ReadLine());
                if (day >=1 && day <= maxDays)
                {
                    Console.WriteLine("Ener your meeting description");
                    var description = Console.ReadLine();
                    Monthes.FirstOrDefault(x => x.Id == monthNumber)
                    ?.Days.FirstOrDefault(x=>x.Id == day)
                    ?.Meetings.Add(description);
                }
            }

        }

        public void ShowMeetings()
        {
            var monthWithMeetings = Monthes.Select(x => new
             {
                 Days = x.Days.Where(d => d.Meetings.Any()),
                 Month = x.Name
             }).ToList();
            foreach ( var m in monthWithMeetings)
            {
                if (m.Days.Any())
                {
                    Console.WriteLine($"Month - {m.Month}");
                    foreach (var d in m.Days)
                    {
                        d.PrintDay();
                    }
                }
            }
        }

    }
}