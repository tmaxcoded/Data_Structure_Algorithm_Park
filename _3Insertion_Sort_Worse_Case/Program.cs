using System;

namespace _3Insertion_Sort_Worse_Case
{
    /*
     
     Analysis:
    • The outer loop is used to pick the value we want to insert into the 
    sorted array in left.
    • The value we want to insert we have picked and saved in a temp 
    variable.
    • The inner loop is doing the comparison using the more() function. 
    The values are shifted to the right until we find the proper position 
    of the temp value for which we are doing this iteration.
    • Finally, the value is placed into the proper position. In each iteration 
    of the outer loop, the length of the sorted array increase by one. 
    When we exit the outer loop, the whole array is sorted.

    Complexity Analysis:
    Worst case time complexity O(n2)
    Best case time complexity O(n)
    Average case time complexity O(n2)
    Space Complexity O(1)
    Stable sorting
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6,4, 5 };
            Console.WriteLine("Begining insertion sort");
            Insertion.Sort(array);
            Console.WriteLine("End insertion sort");
            Console.WriteLine("Printing result");
            for(int i=0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();

        }
    }


    public static class Insertion
    {
        public static bool More(int value1, int value2)
        {
            return value1 > value2;
        }


        public static bool Less(int value1, int value2)
        {
            return value1 < value2;
        }

        public static void Sort(int[] array)
        {
            int size = array.Length;
            int temp = 0;
            int i, j;

            for(i =1; i < size; i++)
            {
                temp = array[i];

                for(j = i; j > 0 && More(array[j -1], temp); j --)
                {
                    array[j] = array[j - 1];
                }

                array[j] = temp;

            }
        } 
    }
}
