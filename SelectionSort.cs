using System;
using System.Diagnostics;

namespace SortingArrays
{
    class SelectionSort
    {
        public void Sort(int[] input)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                int smallestIndex;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    smallestIndex = i;
                    for (int currentIndex = i + 1; currentIndex < input.Length; currentIndex++)
                    {
                        if (input[currentIndex] < input[smallestIndex])
                        {
                            smallestIndex = currentIndex;
                        }
                    }
                    int TemporaryVariable = input[i];
                    input[i] = input[smallestIndex];
                    input[smallestIndex] = TemporaryVariable;
                }

                watch.Stop();
            }
            finally
            {
                PrintArray printArray = new PrintArray();
                printArray.PrintIntegerArray(input);
                Console.WriteLine($" Selection Sort executed in {watch.ElapsedTicks} ticks");
            }
        }
    }
}