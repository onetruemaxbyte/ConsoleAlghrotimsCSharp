using System;
using System.Linq;

namespace ConsoleAlghrotimsCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var rand = new Random();
            var n = rand.Next(1, 10);
            var array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(0, 10);
            }



            MergeSort.Merge_Sort(array.ToList());

            
            Console.WriteLine(Testing.TestAlghrotim());
        }
    }
}
