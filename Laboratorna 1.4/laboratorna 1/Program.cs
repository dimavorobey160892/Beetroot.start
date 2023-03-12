// See https://aka.ms/new-console-template for more information
char symbol = '.';
char entersymbol;
int sum = 0;
do
{
    //entersymbol = Convert.ToChar(Console.Read());
    entersymbol = Console.ReadKey().KeyChar;
    if (entersymbol == ' ')
    {
sum++;
    }
}
while (entersymbol != symbol);
Console.WriteLine(); 
Console.WriteLine($"Кількість пробілів {sum}");
Console.ReadKey();

