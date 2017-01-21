using System;
using System.Collections.Generic;
using System.Linq;

namespace lab16
{
    public class Program
    {
        static int[] arr;

        public static void Main(string[] args)
        {
            Console.Title = "Lab 16";
            int a;
            qSort sort = new qSort();
            do
            {
                Console.WriteLine("Input a positive real number N <200 (array size)");
            }
            while (!int.TryParse(Console.ReadLine(), out a) || a > 200 || a < 0);
            arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                do
                    Console.Write("A[{0}]=", i);
                while
                (!int.TryParse(Console.ReadLine(), out arr[i]));
            }
            Console.WriteLine("Before sort (Length={0})", arr.Length);
            printArr(arr);
            sort.Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("After qSort() (Length={0})", arr.Length);
            printArr(arr);
            int[] sortedArr = new int[arr.Length];
            sortedArr = Filter(arr).ToArray();
            Console.WriteLine("Check for duplicate  (Length{0}",sortedArr.Length);
            printArr(sortedArr);
            if (sortedArr.Length >= 3)
                Console.WriteLine("3 min=" + sortedArr[2]);
            else
                Console.WriteLine("Array length less than 3, can not find third min");
            if (sortedArr.Length >= 4)
                Console.WriteLine("4 max=" + arr[arr.Length - 4]);
            else
                Console.WriteLine("Array length less than 4, can not find fourth max");

            Console.Read();
        }
        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }

        static IEnumerable<int> Filter(int[] array)
        {
            var selectedItems = new List<int>();
            foreach (var i in array)
                if (!selectedItems.Contains(i))
                {
                    selectedItems.Add(i);
                    yield return i;
                }
        }
 
                        


    }
}
