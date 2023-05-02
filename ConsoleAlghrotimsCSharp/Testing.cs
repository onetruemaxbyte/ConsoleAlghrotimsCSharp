using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlghrotimsCSharp
{
    public static class Testing
    {
        public static string TestAlghrotim()
        {
            var random = new Random();
            var n = random.Next(1, 100);
            var arr = new int[n];
            var arr_copy = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(0, 100);
            }
            arr.CopyTo(arr_copy, 0);
            Array.Sort(arr_copy);


            var result = MergeSort.Merge_Sort(arr.ToList()).ToArray();

            

            return result.SequenceEqual(arr_copy) ? "green" : "red";
        }
    }
}
