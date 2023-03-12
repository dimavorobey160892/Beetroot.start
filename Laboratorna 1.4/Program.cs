// See https://aka.ms/new-console-template for more information

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

for (int i =a; i <= b; i++)
{
    for(int j =0; j < i; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();
