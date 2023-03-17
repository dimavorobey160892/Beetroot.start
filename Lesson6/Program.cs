namespace Lesson6
{
    internal class Program
    {
        static void Main()
        {
            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine(Compare(str1, str2));

            string input = "Hello world!!!";

            int numAlphabetic;
            int numDigits;
            int numSpecials;

            Analyze(input, out numAlphabetic, out numDigits, out numSpecials);

            Console.WriteLine(numAlphabetic);
            Console.WriteLine(numDigits);
            Console.WriteLine(numSpecials);

            string str = "multifunctional";
            Console.WriteLine(Sort(str));

            var str5 = "Hello world";

            List<char> chars = DuplicateList(str5);
            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }




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
            Array.Sort(chars, StringComparer.OrdinalIgnoreCase);
            str = new string(chars);
            return str;
        }

        public static List<char>DuplicateList(string str)
        {
            List<char> duplicate = new List<char>();
            List<char> seen = new List<char>();
            foreach (char c in str)
            {
                if (seen.Contains(c) && !duplicate.Contains(c))
                {
                    duplicate.Add(c);
                }
                else 
                {
                    seen.Add(c); 
                }
            }
            return duplicate;
        }
    }
}