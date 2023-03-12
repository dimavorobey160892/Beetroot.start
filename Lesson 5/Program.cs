namespace Lesson_5
{
    internal class Program
    {

        static void selectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                //printArray(arr);
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                {
                    //printArray(arr);
                    if (arr[j] > arr[j + 1])
                    {                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        //printArray(arr);
                    }
                }
        }

        static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                //printArray(arr);
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    //printArray(arr);
                }
                arr[j + 1] = key;
            }
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void Main()
        {
            int[] arr = { 45, 32, 76, 29, 3 };
            //selectionSort(arr);
            //bubbleSort(arr);
            insertionSort(arr);
            Console.WriteLine("Вiдсортований масив");
            printArray(arr);
        }

    }
}