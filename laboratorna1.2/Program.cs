// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Кількість цифр в білеті = ");
var lengthcount =  Convert.ToInt32(Console.ReadLine());

var numbers = Console.ReadLine();
if (numbers.Length == lengthcount)
{
    //int sum1 = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[2]);
    //int sum2 = Convert.ToInt32(numbers[3]) + Convert.ToInt32(numbers[4]) + Convert.ToInt32(numbers[5]);
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < lengthcount/2; i++)
    {
        Console.WriteLine($"i={i}");
     
        sum1+= Convert.ToInt32(numbers[i].ToString());
        Console.WriteLine($"sum1={sum1}");
        sum2+= Convert.ToInt32(numbers[i+lengthcount/2].ToString());
        Console.WriteLine($"sum2={sum2}");
    }
    if (sum1 == sum2)
    {
        Console.WriteLine("Це щасливий квиток!!!!");
    }
    else
    {
        Console.WriteLine("Вам не пощастило!!!");
    }
    

}
else
{
    Console.WriteLine("It's not a ticket!!!");
}


