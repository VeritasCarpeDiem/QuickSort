using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace QuickSort
{
    class Program
    {
        static bool isArrSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    ;
                    return false;
                }
            }
            return true;
        }

        [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
        class Car
        {
            public int Hp { get; set; }

            public Car(int hp)
            {
                Hp = hp;
            }

            private string GetDebuggerDisplay()
            {
                return $"{Hp}";
            }
        }

        [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
        class Car2 : IComparable<Car2>
        {
            public int Hp { get; set; }
            public Car2(int hp)
            {
                Hp = hp;
            }

            public int CompareTo(Car2 other)
            {
                if (Hp == other.Hp)
                {
                    return 0;
                }
                else if (Hp < other.Hp)
                {
                    return -1;
                }
                return 1;

            }

            private string GetDebuggerDisplay()
            {
                return $"{Hp}";
            }
        }


        static void bubblesort(Car[] cars, Func<Car, Car, bool> comp)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (comp(cars[i], cars[j]))
                    {
                        Car temp = cars[i];
                        cars[i] = cars[j];
                        cars[j] = temp;
                    }
                }

            }
        }

        static void Main(string[] args)
        {

            var cars = new Car[]
            {
                new Car(100),
                new Car(10),
                new Car(1000),
                new Car(150),
                new Car(108),
            };


            bubblesort(cars, (a, b) => a.Hp > b.Hp);

            //var cars2 = new Car2[]
            //{
            //    new Car2(100),
            //    new Car2(10),
            //    new Car2(1000),
            //    new Car2(150),
            //    new Car2(108),
            //};





            //Array.Sort(cars, 
            //    (Car car1, Car car2) =>
            //    {
            //        if (car1.Hp == car2.Hp)
            //        {
            //            return 0;
            //        }
            //        else if (car1.Hp < car2.Hp)
            //        {
            //            return -1;
            //        }
            //        return 1;
            //        //return car1.Hp.CompareTo(car2.Hp);
            //    }
            //);

            //QuickSort<Car>.LomutoQuickSort(cars);


            //int[] arr = { 5, 4, 3, 6, 2, 1, 7 };

            //int[] lomuto = new int[] { 7, 4, 3, 6, 2, 1, 5 };

            //Console.WriteLine(isArrSorted(arr));

            //QuickSort<int>.LomutoQuickSort(lomuto);

            //Console.WriteLine(isArrSorted(arr));
        }
    }
}
