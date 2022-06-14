using System.Diagnostics;

namespace Algorithms;
internal class Program
{
    public static void Main()
    {
        string result = "";

        int[] myArray = new int[400000];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i;
        }
        Random random = new Random();
        myArray = myArray.OrderBy(x => random.Next()).ToArray();


        //printArray(myArray);



        int[] mySortArray1 = new int[myArray.Length];
        myArray.CopyTo(mySortArray1, 0);

        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        //mySortArray1 = Sort.QuickSort(myArray);
        stopwatch1.Stop();

        Console.WriteLine();
        //printArray(mySortArray1);




        int[] mySortArray2 = new int[myArray.Length];
        myArray.CopyTo(mySortArray2, 0);
        
        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        mySortArray2 = Sort.SelectionSort(mySortArray2);
        stopwatch2.Stop();




        int[] mySortArray3 = new int[myArray.Length];
        myArray.CopyTo(mySortArray3, 0);
        Stopwatch stopwatch3 = new Stopwatch();
        stopwatch3.Start();
        mySortArray3 = Sort.BubbleSort(mySortArray3);
        stopwatch3.Stop();
        

        //Console.WriteLine("Elapsed Time 1 is {0} ms", stopwatch.ElapsedMilliseconds);
        Console.WriteLine("Elapsed Time 2 is {0} ms", stopwatch2.ElapsedMilliseconds);
        Console.WriteLine("Elapsed Time 3 is {0} ms", stopwatch3.ElapsedMilliseconds);





        void printArray(int[] arr)
        {
            result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i] + ",\n";
            }
            Console.WriteLine(result);
            Console.WriteLine("----------------------------------------------------------");
        }
    }

}

