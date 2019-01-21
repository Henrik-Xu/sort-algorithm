using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithm;

namespace sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 80, 30, 90, 40, 50, 70 };

            BubbleSortAlgorithm bubbleSort = new BubbleSortAlgorithm();

            InsertSortAlgorithm insertSort = new InsertSortAlgorithm();

            ShellSortAlgorithm shellSort = new ShellSortAlgorithm();

            HeapSortAlgorithm heapSort = new HeapSortAlgorithm();

            SelectionSortAlgorithm selectSort = new SelectionSortAlgorithm();

            MergeSortAlgorithm mergeSort = new MergeSortAlgorithm();

            QuickSortAlgorithm quickSort = new QuickSortAlgorithm();


            arr = quickSort.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
