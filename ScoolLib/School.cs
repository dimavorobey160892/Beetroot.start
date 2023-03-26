namespace SchoolLib
{
    public class School
    {
        public List<Class> Classes { get; private set; }
        public List<Teacher> Teachers { get; set; }
        public List<Schedule> Schedules 
        { 
            get 
            {
                var schedules = new List<Schedule>();
                foreach (var c in Classes)
                {
                    schedules.AddRange(c.Schedules);
                }
                return schedules;
            }
        }
        public void AddClass (Class @class)
        {
            Classes.Add(@class);
        }
        public void RemoveClass (string className)
        {
            Classes.RemoveAll(c => c.Name == className);
        }
        
    }
}