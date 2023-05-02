using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlghrotimsCSharp
{
    public static class QuickSort
    {
        public static void Quick_Sort(int[] array)
        {
            Quick_Sort(array, 0, array.Length);
        }

        private static void Quick_Sort(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int pivot = Partition(array, i, j); // [i, pivot - 1] < pivot // [pivot + 1, j] > pivot
            Quick_Sort(array, i, pivot);
            Quick_Sort(array, pivot + 1, j);
        }

        private static int Partition(int[] array, int i, int j)
        {
            int pivot = i;
            int s1_index = i;
            int s2_index = i;

            for (int k = i; k < j; k++)
            {
                if (array[k] >= array[pivot])
                {
                    s2_index++;
                }
                else
                {
                    s1_index++;
                    Swap(array[s1_index], array[k]);
                    s2_index++;
                }
            }

            return pivot;
        }

        private static int Swap(int i, int j)
        {

            return 0;
        }
    }
}
