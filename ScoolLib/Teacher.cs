using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Teacher 
    {
        public Teacher(string firstName, string lastName, Subject subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Subject Subject { get; private set; }

        public void UpdateInfo (string firstName, string lastName, Subject subject)
        {
            FirstName = firstName; 
            LastName = lastName; 
            Subject = subject;
        }

    }
}
