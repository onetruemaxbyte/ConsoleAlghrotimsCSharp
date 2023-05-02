using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlghrotimsCSharp
{
    public static class BubbleSort
    {
        public static int[] Bubble_Sort(int[] array)
        {
            bool isSorted = true;
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 1; i < array.Length - j; i++)
                {
                    isSorted = false;
                    if (array[i] < array[i - 1])
                        Swap(i, i - 1, array);
                }

                if (isSorted)
                {
                    break;
                }
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
