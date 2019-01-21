using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /*
     * Selection Sort:选择排序
     * The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from 
     * unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.
     * 1) The subarray which is already sorted.
     * 2) Remaining subarray which is unsorted.
     * Time Complexity: O(n^2)
     */
    public class SelectionSortAlgorithm : ISortAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i=1; j < length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        SortHelp.Swap(arr,i,j);
                    }
                }
            }

            return arr;
        }
    }
}
