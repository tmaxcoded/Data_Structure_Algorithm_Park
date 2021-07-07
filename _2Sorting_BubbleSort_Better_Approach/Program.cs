using System;

namespace _2Sorting_BubbleSort_Better_Approach
{
    /*
        By applying this improvement, best-case performance of this algorithm is 
        improved when an array is nearly sorted. In this case, we just need one 
        single pass and the best-case complexity is O(n)

        Complexity Analysis:
        Worst case performance O(n2)
        Average case performance O(n2)
        Space Complexity O(1) 
        Adaptive: When array is nearly sorted O(n)
        Stable Sorting Yes
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6,4, 5 };
            

            Console.WriteLine("Begin Swapping ...... ");
            BubbleSort.BubbleSwap(array);
            Console.WriteLine("End Swapping .........");
            Console.WriteLine("Begin printing result....");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("</b> End printing.....");
            Console.ReadKey();
        }
    }

    public static class BubbleSort
    {
        public static bool More(int value1, int value2)
        {
            return value1 > value2;
        }

        public static bool Less(int value1, int value2)
        {
            return value1 < value2;
        }


        public static void BubbleSwap(int[] numbers)
        {
            int dataSize = numbers.Length;
            int fullySwapped = 1;
            int temp = 0;

            for(int i=0; i < (dataSize -1) && fullySwapped == 1; i++)
            {
                fullySwapped = 0;
                for(int j=0; j < dataSize - i - 1; j++)
                {
                    if(More(numbers[j], numbers[j + 1]))
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        fullySwapped = 1;

                    }

                }
            }
        }
    }
}
