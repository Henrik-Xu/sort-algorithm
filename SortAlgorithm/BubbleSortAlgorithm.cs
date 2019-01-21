using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /*
     * Bubble Sort
     * Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
     * Time Complexity: O(n^2)
     * The above function always runs O(n^2) time even if the array is sorted. It can be optimized by stopping the algorithm if inner loop didn’t cause any swap.
     */
    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        SortHelp.Swap(arr, j, j + 1);
                    }
                }
            }
            return arr;
        }
    }
}
