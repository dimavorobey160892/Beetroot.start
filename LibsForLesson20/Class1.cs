namespace LibsForLesson20
{
    public class Class1
    {
        public int ID;
        public string Name { get; set; }
        public string Description { get; set; }
        public Class1() { }
        public Class1(string name) {  Name = name; }
        public void About () 
        {
            Console.WriteLine("Hello!!!");
        }
    }
}