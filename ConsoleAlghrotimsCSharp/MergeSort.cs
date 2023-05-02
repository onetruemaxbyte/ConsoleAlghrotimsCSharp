using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlghrotimsCSharp
{
    public static class MergeSort
    {
        public static List<int> Merge_Sort(List<int> array)
        {
            if (array.Count <= 1)
                return array;

            var left = new List<int>();
            var right = new List<int>();

            int n = array.Count / 2;

            for (int i = 0; i < n; i++)
                left.Add(array[i]);
            for (int i = n; i < array.Count; i++)
                right.Add(array[i]);

            left = Merge_Sort(left);
            right = Merge_Sort(right);

            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            var merged = new List<int>();
            int left_index = 0, right_index = 0;

            while (left_index < left.Count && right_index < right.Count)
            {
                if (left[left_index] <= right[right_index])
                {
                    merged.Add(left[left_index++]);
                }
                else
                {
                    merged.Add(right[right_index++]);
                }
            }
            
            while (left_index < left.Count)
            {
                merged.Add(left[left_index++]);
            }
            while (right_index < right.Count)
            {
                merged.Add(right[right_index++]);
            }

            return merged;
        }
    }
}
