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



        public static void QuickSort(int[] arr, int min, int max)
        { 
            if (min >= max)
            {
                return;
            }

            int temp;

            //Random r = new Random();
            //int pivot = r.Next(min, max);

            //temp = arr[max];
            //arr[max] = arr[pivot];
            //arr[pivot] = temp;
            
            int i = min-1;
            for (int j = min; j <= max; j++)
            {
               if(arr[j] < arr[max])
               {
                    i++;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
               }
            }
            temp = arr[++i];
            arr[i] = arr[max];
            arr[max] = temp;

            QuickSort(arr, min, i-1);
            QuickSort(arr, i+1, max);

        }




        public static void QuickSortPrint(int[] arr, int min, int max)
        {
            if (min >= max)
            {
                return;
            }
            Console.WriteLine();
            Console.Write($"starting array: ");
            for (int a = min; a <= max; a++)
            {
                Console.Write($"{arr[a]},");
            }


            Random r = new Random();
            int
            pivot = r.Next(min, max),
            temp;
            Console.WriteLine();
            Console.WriteLine("pivot index:" + pivot + ", pivot vallue: " + arr[pivot] + "\n");
            temp = arr[max];
            arr[max] = arr[pivot];
            arr[pivot] = temp;
            //Program.printArray(arr);

            int i = min - 1;
            for (int j = min; j <= max; j++)
            {

                if (arr[j] < arr[max])
                {
                    i++;
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    Console.WriteLine($"swapt: {arr[j]} with: {arr[i]}");
                    Program.printArray(arr);
                }
            }
            temp = arr[++i];
            arr[i] = arr[max];
            arr[max] = temp;

            string arr1 = "";
            string arr2 = "";
            for (int a = min; a < i; a++)
            {
                arr1 += $"{arr[a]},";
            }
            for (int a = i + 1; a <= max; a++)
            {
                arr2 += $"{arr[a]},";
            }

            Console.WriteLine($"low({arr1}) ({arr[i]}) high({arr2}) ");
            Console.WriteLine();
            Console.WriteLine();
            QuickSort(arr, min, i - 1);
            QuickSort(arr, i + 1, max);
        }



    }
     
}
