using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlghrotimsCSharp
{
    public static class CountingSort
    {
        public static int[] Counting_Sort(int[] array)
        {
            int minimum = array[0];
            int maximum = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maximum)
                    maximum = array[i];
                if (array[i] < minimum)
                    minimum = array[i];
            }

            var bucket = new int[maximum - minimum + 1];

            for (int i = 0; i < array.Length; i++)
            { 
                bucket[array[i] - minimum]++;
            }

            Array.Clear(array, 0, array.Length);
            var result = new List<int>();

            for (int i = 0; i < bucket.Length; i++)
            {
                int count = bucket[i];
                for (int j = 0; j < count; j++)
                {
                    result.Add(i + minimum);
                }
            }

            return result.ToArray(); 
        }
    }
}
