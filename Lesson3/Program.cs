// See https://aka.ms/new-console-template for more information
namespace ConditionOperator;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Input x ...");
        var x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x="+x);

        Console.WriteLine("Input y ...");
        var y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("y=" + y);

        if (x == y)
        {
            Console.WriteLine("Sum=" + x);
        }
        else if (y > x)
        {
            WriteSum(x, y);
        }
        else
        {
            WriteSum(y, x);
        }

    }

    static void WriteSum(int startNumber, int endNumber)
    {
        int sum = startNumber;
        Console.Write("Sum=" + startNumber);
        for (var i = startNumber + 1; i <= endNumber; i++)
        {
            sum += i;
            Console.Write("+" + i);
        }
        Console.Write("=" + sum);
    }


}




