using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class HeapSortAlgorithm : ISortAlgorithm
    {
        /*
         * Heap Sort：Heap sort is a comparison based sorting technique based on Binary Heap data structure. 
         * 1. Build a max heap from the input data.
         * 2. 第一个元素和最后一个元素交换位置，然后 heaptiy 第一个元素
         * 3. 重复交换，重复堆化
         * Time Complexity: O(nlogn)
         */
        public int[] Sort(int[] arr)
        {
            int arrsize = arr.Length;
            int index = arrsize / 2 - 1;
            for (int i = index; i >= 0; i--)
            {
                Heapify(arr,arrsize,i);
            }

            for (int i = arrsize-1; i >=0; i--)
            {
                SortHelp.Swap(arr,i,0);

                Heapify(arr,i,0);
            }

            return arr;
        }

        public void Heapify(int[] arr,int arrsize,int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int larget = index;
            if (left > 0 && left < arrsize && arr[left] > arr[larget])
            {
                larget = left;
            }
            if(right>0 && right <arrsize && arr[right] > arr[larget])
            {
                larget = right;
            }
            if (larget != index)
            {
                SortHelp.Swap(arr,index,larget);

                Heapify(arr,arrsize,larget);
            }
        }
    }
}
