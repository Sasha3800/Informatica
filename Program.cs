using System;
using System.Linq;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Lab 16";
            Random rnd = new Random();
            int a;
            do
            {
                Console.WriteLine("Input a positive real number N <200 (array size)");
            }
            while (!int.TryParse(Console.ReadLine(), out a) || a > 200);
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                do
                    Console.Write("A[{0}]=", i+1);
                while
                (!int.TryParse(Console.ReadLine(), out arr[i]));
            }
            Console.WriteLine("Before sort (Length={0})", arr.Length);
            printArr(arr);
            int[] sortedArr = new int[arr.Length];
            sortedArr = arr;
            Array.Sort(sortedArr, 0, arr.Length);
            sortedArr = sortedArr.Distinct().ToArray();
            Console.WriteLine("After sort (Length={0})", sortedArr.Length);
            printArr(sortedArr);
            if (arr.Length >= 3)
                Console.WriteLine("3 min=" + sortedArr[2]);
            else
                Console.WriteLine("Array length less than 3, can not find third min");
            if (arr.Length >= 4)
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


    }
}
