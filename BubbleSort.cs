using System;
using System.Diagnostics;

namespace SortingArrays
{
    class BubbleSort
    {
        public void Sort(int[] input)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                for (int i = 0; i <= input.Length - 2; i++)
                {
                    for (int j = 0; j <= input.Length - 2; j++)
                    {
                        if (input[j] > input[j + 1])
                        {
                            int Temp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = Temp;
                        }
                    }
                }

                watch.Stop();
            }
            finally
            {
                PrintArray printArray = new PrintArray();
                printArray.PrintIntegerArray(input);
                Console.WriteLine($" Bubble Sort executed in {watch.ElapsedTicks} ticks");
            }
        }
    }
}
