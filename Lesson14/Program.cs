namespace Lesson14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
           var _deleted = stack.Pop();
            stack.Push(6);
           var _backend = stack.Peek();
            int[] newArr = new int[2];
            stack.CopyTo(ref newArr);
        }
    }
}