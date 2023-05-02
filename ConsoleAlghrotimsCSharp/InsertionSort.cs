using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlghrotimsCSharp
{
    class InsertionSort
    {
        public static int[] Insertion_Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int curr = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > curr)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = curr;
            }

            return array;
        }
    }
}
