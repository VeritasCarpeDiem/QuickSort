using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class QuickSort<T> where T : IComparable<T>
    {
        private static int LomutoPartition(T[] arr,int low, int high)
        {
            int pivot = high; //set pivot to highest value of arr
            int wall = low - 1; 

            for ( int i = low; i < high; i++) //can't be arr.Length
            {
                if (arr[i].CompareTo(arr[pivot])<0)
                {
                    wall++;
                    Swap(ref arr[i], ref arr[wall]);
                    
                }
                //ignore any values that are greater than pivot
            }

            //guarentees pivot is in the right spot so we can exclude
            //it in next recursive calls
            Swap(ref arr[high],ref arr[wall+1]);
            return wall + 1;
        }
        public static T[] LomutoQuickSort(T[] arr) //the return type can void b/c arrays passed bvy reference
        {
            QuickSort(arr, 0, arr.Length-1);

            return arr;

            void QuickSort(T[] arr, int low, int high) //helper function 
            {
                if (low< high)
                {
                    int pivot = LomutoPartition(arr, low, high);

                    ;
                    QuickSort(arr, low, pivot-1);//sort left

                    QuickSort(arr, pivot + 1, high); //sort right
                }
            }
        }
        public static T[] HoareQuickSort(T[] arr)
        {
            
            QuickSort(arr, 0, arr.Length - 1);
            
            return arr;

            void QuickSort(T[] arr,int low, int high) //helper function 
            { 
                if (low < high)
                {
                    int pivot = HoarePartition(arr, low, high);

                    ;
                    QuickSort(arr, low, pivot);//sort left

                    QuickSort(arr, pivot + 1, high); //sort right
                }
            }
            
        }
        private static int HoarePartition(T[] arr, int low, int high)
        {
            T pivot = arr[low];
            int leftPtr = low - 1;
            int rightPtr = high + 1;

            while(true)
            {
                do
                {
                    leftPtr++;
                } while (arr[leftPtr].CompareTo(pivot) < 0);
                do
                {
                    rightPtr--;
                } while (arr[rightPtr].CompareTo(pivot) > 0);
               
                if(leftPtr>=rightPtr) //?
                {
                    return rightPtr; //this is new "wall"
                 
                }
                Swap(ref arr[leftPtr], ref arr[rightPtr]);
            }
        }
        static void Swap(ref T num1, ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }


    }
}
