// See https://aka.ms/new-console-template for more information
var text = Console.ReadLine();
string result = "";
for (var i = 0; i<text.Length; i++)
{
    if (Char.IsLetter(text[i]))
    {
        if (Char.IsLower(text[i]))
        {
            //text[i] = Char.ToUpper(text[i]);
           result = result + Char.ToUpper(text[i]);
        }
        else
        {
            result = result + Char.ToLower(text[i]);
        }
        
    }
    else
    {
        result = result + text[i];
    }
}
Console.WriteLine(result);
Console.(ConsoleColor.Yellow);
Console.ReadKey();