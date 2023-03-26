using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Class
    {
        public string Name { get; set; }
        internal List<Pupil> Pupils { get; }
        public Teacher Teacher { get; set; }
        public List<Schedule> Schedules{ get; set; }

        public void AddPupil(string FirstName, string LastName, int Age)
        {
            Pupils.Add(new Pupil { FirstName = FirstName, LastName = LastName, Age = Age });
        }
        public void AddSchedule(string day, List<Subject> subject)
        {
            Schedules.Add(new Schedule
            {
                Day = day,
                Subjects = subject
            });
        } 
        

    }
}
