using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /*
     * Shell Sort
     * 希尔排序：希尔排序采用增量排序，在使用增量 h(k) 的一趟排序之后，所有相隔 h(k) 的元素都被排序.
     * Time Complextity: O(n^2)
     */
    public class ShellSortAlgorithm : ISortAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            int length = arr.Length;

            for (int gap = length/2; gap >0; gap/=2)
            {
                for (int i = gap; i < length; i++)
                {
                    for (int j = i; j-gap >=0; j-=gap)
                    {
                        if(arr[j]<arr[j-gap])
                        {
                            SortHelp.Swap(arr,j,j-gap);
                        }
                    }
                }
            }

            return arr;
        }
    }
}
