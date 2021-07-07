using System;

namespace _1Sorting_BubbleSort_Worst_Case
{
    class Program
    {
        /*
         
         Analysis:
            • The outer loop represents the number of swaps that are done for 
            comparison of data.
            • The inner loop is actually used to do the comparison of data. At the end 
            of each inner loop iteration, the largest value is moved to the end of the 
            array. In the first iteration the largest value, in the second iteration the 
            second largest and so on.
            • more() function is used for comparison which means when the value of 
            the first argument is greater than the value of the second argument then 
            perform a swap. By this we are sorting in increasing order if we have, 
            the less() function in place of more() then array will be sorted in 
            decreasing order.

        Complexity Analysis:
            Each time the inner loop execute for (n-1), (n-2), 
          (n-3)…(n-1) + (n-2) + (n3) + ..... + 3 + 2 + 1 = n(n-1)/2

        Worst case performance O(n2)
        Average case performance O(n2)
        Space Complexity O(1) as we need only one temp variable Stable Sorting Yes

         */

        static void Main(string[] args)
        {
            int[] numbers = { 2, 0, 4, 6, 1, 2, 3, 8, 21, 78 };
            Console.WriteLine("Begin Swapping ...... ");
            BubbleSort.BubbleSwap(numbers);
            Console.WriteLine("End Swapping .........");
            Console.WriteLine("Begin printing result....");
            for(int i =0; i < numbers.Length -1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("</b> End printing.....");
            Console.ReadKey();
        }
    }


    public static class BubbleSort
    {
        public static bool More(int valu1, int value2)
        {
            return valu1 > value2;
        }

        public static bool Less(int value1, int value2)
        {
            return value1 < value2;
        }


        public static void BubbleSwap(int[] data)
        {
            int dataSize = data.Length;
            int temp = 0;
            for(int i =0; i < dataSize -1; i++)
            {
                for(int j= 0; j < (dataSize - i - 1); j++)
                {
                    if(More(data[j], data[j + 1]))
                    {
                        temp = data[j];
                        data[j + 1] = data[j];
                        data[j] = temp;

                    }
                }
            }
        }
    }
}
