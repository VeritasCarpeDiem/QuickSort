using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {
        private static int LomutoPartition(int[] arr,int low, int high)
        {
            int pivot = arr[high]; //set pivot to highest value of arr
            int wall = low - 1; 

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<pivot)
                {
                    Swap(ref arr[i], ref arr[wall]);
                    wall++;
                }
                //ignore any values are greater than pivot
            }

            Swap(ref arr[pivot],ref arr[wall+1]);
            return wall + 1;
        }
        public static int[] QuickSortLomuto(int arr)
        {
            
        }
        void HoarePartition()
        {

        }
        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }


    }
}
