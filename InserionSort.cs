using System;
using System.Diagnostics;

namespace SortingArrays
{
    class InsertionSort
    {
        public void Sort(int[] input)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (input[j - 1] > input[j])
                        {
                            int TemporaryVariable = input[j];
                            input[j] = input[j - 1];
                            input[j - 1] = TemporaryVariable;
                        }
                    }
                }

                watch.Stop();
            }
            finally
            {
                PrintArray printArray = new PrintArray();
                printArray.PrintIntegerArray(input);
                Console.WriteLine($" Insertion Sort executed in {watch.ElapsedTicks} ticks");
            }
        }
    }
}