using System.Diagnostics;

namespace Algorithms;
internal class Program
{
    public static void Main()
    {
        int[] myArray = new int[100000];
        Random random = new Random();

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = random.Next(1,100);
        }
        Console.WriteLine($"made a Array of {myArray.Length} random items");

        //myArray = myArray.OrderBy(x => random.Next()).ToArray();

        //Console.WriteLine("original:");
        //printArray(myArray);




        int[] mySortArray1 = new int[myArray.Length];
        myArray.CopyTo(mySortArray1, 0);
        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        Sort.QuickSort(mySortArray1, 0, mySortArray1.Length - 1);
        stopwatch1.Stop();
        Console.WriteLine("Elapsed Time for QuickSort is {0} ms", stopwatch1.ElapsedMilliseconds);


        int[] mySortArray2 = new int[myArray.Length];
        myArray.CopyTo(mySortArray2, 0);
        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        Sort.SelectionSort(mySortArray2);
        stopwatch2.Stop();
        Console.WriteLine("Elapsed Time for SelectionSort is {0} ms", stopwatch2.ElapsedMilliseconds);


        int[] mySortArray3 = new int[myArray.Length];
        myArray.CopyTo(mySortArray3, 0);
        Stopwatch stopwatch3 = new Stopwatch();
        stopwatch3.Start();
        Sort.BubbleSort(mySortArray3);
        stopwatch3.Stop();
        Console.WriteLine("Elapsed Time for BubbleSort is {0} ms", stopwatch3.ElapsedMilliseconds);



        //printArray(mySortArray1);
        //printArray(mySortArray2);
        //printArray(mySortArray3);






    }


    public static void printArray(int[] arr)
    {
        string result = "\n";
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i] + ",";
        }
        Console.WriteLine(result);
        Console.WriteLine("----------------------------------------------------------");
    }

}

