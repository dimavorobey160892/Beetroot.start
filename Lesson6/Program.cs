namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static bool Compare(string str1, string str2)
        {
            if(str1.Length != str2.Length)
            {
                return false;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Analyze(string input, 
                           out int numAlphabetic, 
                           out int numDigits, 
                           out int numSpecials)
        {
            numAlphabetic = 0;
            numDigits = 0;
            numSpecials = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    numAlphabetic++;
                }
                else if (char.IsDigit(c))
                {
                    numDigits++;
                }
                else
                {
                    numSpecials++;
                }
            }
        }
        public static string Sort(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars, StringComparer.OrdinalIgnoreCase,);
            str = new string(chars);
            return str;
        }
    }
}