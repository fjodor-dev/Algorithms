using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class Sort
    {

        public static int[] SelectionSort(int[] arr)
        {
            int temp, min, n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }

        public static void SelectionSortVoid(int[] arr)
        {
            int temp, min, n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            
        }

        public static int[] SelectionSortPrint(int[] arr)
        {
            int temp, min;

            for (int i = 0; i < arr.Length; i++)
            {
                min = i;
                Console.Write($"{i}: ");
                Console.Write("sorted: ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{j},");
                }

                Console.Write("unsorted: ");
                Console.Write($"{min},");

                for (int j = i + 1; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + ",");
                    if (arr[j] < arr[min])
                    {

                        min = j;
                    }
                }
                Console.WriteLine($" min: {min}");
                Console.WriteLine("");
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }

 
        public static int[] BubbleSort(int[] arr)
        {
            int n = arr.Length - 1, temp;
            bool notSorted;
            do
            {
                notSorted = false;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        notSorted = true;
                    }
                }
            }
            while(notSorted);
            return arr;
        }


        public static int[] QuickSort(int[] arr)
        {
            Random r = new Random();
            int n = arr.Length, 
            temp,
            pivot = r.Next(0, n),
            pivotVal = arr[pivot];
            //Console.WriteLine(myArray[pivot]);
            //for (int i = 0; i < 100; i++)
            //{

            //    pivot += r.Next(0, n);

            //}
            //pivot /= 100;
            Console.WriteLine("pivot index:" + pivot + ", pivot vallue: " + pivotVal);
            temp = arr[n-1];
            arr[n-1] = arr[pivot];
            arr[pivot] = temp;

            int itemL, itemR;

            int i = 0;
            for (int j = 0; j < n-1; j++)
            {
               if(arr[j] < pivotVal)
               {
                    i++;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    Console.WriteLine($"swapt: {arr[i]} with: {arr[j]}");
                }
                
            }

            Console.WriteLine(i);
            return arr;
        }




    }
     
}
