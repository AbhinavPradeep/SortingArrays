using System;

namespace SortingArrays
{
    class PrintArray
    {
        public  void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}