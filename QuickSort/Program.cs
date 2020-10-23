using System;
using System.Reflection.Metadata.Ecma335;

namespace QuickSort
{
    class Program
    {
        static bool isArrSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1] )
                {
                    ;
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 6, 2, 1, 7 };

            int[] lomuto = new int[] { 7, 4, 3, 6, 2, 1, 5 };

            Console.WriteLine(isArrSorted(arr));

            QuickSort.LomutoQuickSort(lomuto);

            Console.WriteLine(isArrSorted(arr));
        }
    }
}
