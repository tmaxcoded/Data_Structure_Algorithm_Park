using System;

namespace _3Selection_Sort_Worse_Case
{
    /*
     Analysis:
    • The outer loop decides the number of times the inner loop will 
        iterate. For an input of N elements, the inner loop will iterate N 
        number of times. 
    • In each iteration of the inner loop, the largest value is calculated 
        and is placed at the end of the array. 
    • This is the final replacement of the maximum value to the proper 
        location. The sorted array is created backward.


    Complexity Analysis:
    Worst Case time complexity O(n2)
    Best Case time complexity O(n2)
    Average case time complexity O(n2)
    Space Complexity O(1)
    Stable Sorting No
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6,4, 5 };
            Console.WriteLine("Begining selection sort");
            Selection.Sort2(array);
            Console.WriteLine("End selection sort");
            Console.WriteLine("Printing result");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }


    public static class Selection
    {
        public static bool More(int val1, int val2)
        {
            return val1 > val2;
        }

        public static bool Less(int val1, int val2)
        {
            return val1 < val2;
        }



        public static void Sort2(int[] arr)
        {
            int size = arr.Length;
            int i, j, temp, min;
            for(i = 0; i < size -1; i++)
            {
                min = i;
                for(j =i + 1; j < size; j++)
                {
                    if (Less(arr[j], arr[min]))
                    {
                        min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;



            }
        }

        public static void Sort(int[] arr)
        {
            int size = arr.Length;
            int i, j, temp,max;
            for(i = 0; i < size -1 ; i++)
            {
                max = 0;
                for(j = 1; j < size -1 -i; j++)
                {
                    if(More(arr[j] ,arr[max]))
                    {
                        max = j;
                    }

                }


                temp = arr[size - 1 - i];
                arr[size - 1 - i] = arr[max];
                arr[max] = temp;
            }
        }
    }
}
