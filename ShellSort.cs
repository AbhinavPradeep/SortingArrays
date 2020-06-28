using System;
using System.Diagnostics;

namespace SortingArrays
{
    class ShellSort
    {
        public void Sort(int[] input, int array_size)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                int i, j, inc, temp;
                inc = 3;
                while (inc > 0)
                {
                    for (i = 0; i < array_size; i++)
                    {
                        j = i;
                        temp = input[i];
                        while ((j >= inc) && (input[j - inc] > temp))
                        {
                            input[j] = input[j - inc];
                            j = j - inc;
                        }
                        input[j] = temp;
                    }
                    if (inc / 2 != 0)
                        inc = inc / 2;
                    else if (inc == 1)
                        inc = 0;
                    else
                        inc = 1;
                }

                watch.Stop();
            }
            finally
            {
                PrintArray printArray = new PrintArray();
                printArray.PrintIntegerArray(input);
                Console.WriteLine($" Shell Sort executed in {watch.ElapsedTicks} ticks");
            }
        }
    }
}