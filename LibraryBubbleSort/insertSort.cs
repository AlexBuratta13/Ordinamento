using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBubbleSort
{
    class insertSort
    {
        public static void ShiftR(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int n = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > n)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = n;
            }
        }
    }
}
