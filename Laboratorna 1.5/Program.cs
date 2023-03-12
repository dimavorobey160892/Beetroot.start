
// See https://aka.ms/new-console-template for more information
Start:
var text = Console.ReadLine();
char[] numbers = text.ToCharArray();
Array.Reverse(numbers);

string revers = new string(numbers);
int result = 0;
bool isNumeric = int.TryParse(revers, out result);
if (isNumeric)
{
    Console.WriteLine($"result ={result}");
}
else
{
    Console.WriteLine("Its not a number");
    
}


Console.ReadKey();
Console.Clear();
goto Start;
