using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAlghrotimsCSharp
{
    public static class SelectionSort
    {
        public static int[] Selection_Sort(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int minIndex = j;

                for (int i = j; i < array.Length; i++)
                {
                    if (array[minIndex] > array[i])
                        minIndex = i;
                }

                Swap(j, minIndex, array);
            }

            return array;
        }

        static void Swap(int ind1, int ind2, int[] array)
        {
            var ind = array[ind1];
            array[ind1] = array[ind2];
            array[ind2] = ind;
        }
    }

        
}
