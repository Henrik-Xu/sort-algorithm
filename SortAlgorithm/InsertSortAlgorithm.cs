using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /*
     * Insertion Sort
     * Insertion sort is a simple sorting algorithm that works the way we sort playing cards in our hands.
     * TimeComplexity :O(n^2)
     * Insertion sort is used when number of elements is small. 
     * It can also be useful when input array is almost sorted, only few elements are misplaced in complete big array.
     */
    public class InsertSortAlgorithm : ISortAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (arr[j+1] < arr[j])
                    {
                        SortHelp.Swap(arr,j,j+1);
                    }
                }
            }

            return arr;
        }
    }
}
