namespace Lesson4
{
    internal class Program
    {
        static void Main()
        {
            var max1 = FindMax(1, 63, 5, 87, 9);
            var max2 = FindMax(0, 7, 54);
            var max3 = FindMax(3, 0, 21, -2);

            Console.WriteLine("Max1 = " + max1);
            Console.WriteLine("Max2 = " + max2);
            Console.WriteLine("Max3 = " + max3);

            var min1 = FindMin(60, 65, -35, 0, -4, 54);
            var min2 = FindMin(4, 0, -3);
            var min3 = FindMin(54, 32, 1, -65);

            Console.WriteLine("Min1 = " + min1);
            Console.WriteLine("Min2 = " + min2);
            Console.WriteLine("Min3 = " + min3);

            int sum;
            bool isOdd = TrySumIfOdd(start: 45, end: 21, out sum);
            Console.WriteLine("Sum is " + sum + ", is Od " + isOdd);



        }
        public static int FindMax(params int[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0;
            }

            int max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            return max;
        }
        public static int FindMin(params int[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0;
            }

            int min = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }

            return min;
        }
        public static bool TrySumIfOdd(int start, int end, out int sum)
        {
            sum = 0;
            if (start == end) return false;

            if (end > start)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            for (var i = start + 1; i < end; i++) ;
            sum += 1;
            bool isOd = sum % 2 == 1;
            return isOd;
        }
        public static int FindMax(int first, int second, int third)
        {
            if ((first >= second) && (first >= third))
            {
                return first;
            }
            else if ((second >= first) && (second >= third))
            {
                return second;
            }
            else
            {
                return third;
            }
        }
        public static int FindMax(int first, int second, int third, int fourth)
        {
            if ((first >= second) && (first >= third) && (first >= fourth))
            {
                return first;
            }
            else if ((second >= first) && (second >= third) && (second>=fourth))
            {
                return second;
            }
            else if ((third >= first) && (third >= second) && (third >= fourth))
            {
                return third;
            }
            else
            {
                return fourth;
            }
        }
        public static int FindMin(int first, int second, int third)
        {
            if ((first <= second) && (first <= third))
            {
                return first;
            }
            else if ((second <= first) && (second <= third))
            {
                return second;
            }
            else
            {
                return third;
            }

        }
        public static int FindMin(int first, int second, int third, int fourth)
        {
            if ((first <= second) && (first <= third) && (first<= fourth))
            {
                return first;
            }
            else if ((second <= first) && (second <= third) && (second <= fourth))
            {
                return second;
            }
            else if ((third <=first) && (third<= second) && (third <= fourth))
            {
                return third;
            }
            else
            {
                return fourth;
            }

        }

    }
}
