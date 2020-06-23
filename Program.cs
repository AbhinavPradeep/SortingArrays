using System;

namespace SortingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            InsertionSort insertionSort = new InsertionSort();
            SelectionSort selectionSort = new SelectionSort();
            PrintArray printArray = new PrintArray();
            Console.Write("Unsorted Array \n");
            int[] Array = new int[] {1234134,234239423,4234,234823,4234,234,23948,2349,234,2394,2398423,4293423,42342384,23,423,8942,3948,23842,348384};
            printArray.PrintIntegerArray(Array);
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Bubble Sorted Array \n");
            bubbleSort.Sort(Array);
            Console.Write("\n");
            Console.Write("Insertion Sorted Array \n");
            insertionSort.Sort(Array);
            Console.Write("\n");
            Console.Write("Selection Sorted Array \n");
            selectionSort.Sort(Array);
        }
    }
}
