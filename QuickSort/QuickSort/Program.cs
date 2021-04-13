using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create random array of integers
            int min = 0;
            int max = 100;
            Random random = new Random();
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }

            Console.WriteLine("Original array : ");
            foreach(var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach(var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(arr, left, right);

                if(pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if(pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while(true)
            {
                while(arr[left] < pivot)
                {
                    left++;
                }
                while(arr[right] > pivot)
                {
                    right--;
                }

                if(left < right)
                {
                    if(arr[left] == arr[right])
                    {
                        return right;
                    }
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
