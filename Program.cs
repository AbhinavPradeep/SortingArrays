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
            ShellSort shellSort = new ShellSort();
            PrintArray printArray = new PrintArray();
            Console.Write("Unsorted Array \n");
            int[] Array = new int[] {9,8,7,6,5,4,3,2,1};
            printArray.PrintIntegerArray(Array);
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Insertion Sorted Array \n");
            insertionSort.Sort(Array);
            Console.Write("\n");
            Console.Write("Bubble Sorted Array \n");
            bubbleSort.Sort(Array);
            Console.Write("\n");
            Console.Write("Selection Sorted Array \n");
            selectionSort.Sort(Array);
            Console.Write("\n");
            Console.Write("Shell Sorted Array \n");
            shellSort.Sort(Array,9);
        }
    }
}
