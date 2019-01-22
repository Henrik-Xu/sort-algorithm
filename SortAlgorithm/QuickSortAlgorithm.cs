using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /*
     * Quick Sort:(快速排序)
     * QuickSort is a Divide and Conquer algorithm. It picks an element as pivot and partitions the given array around the picked pivot. 
     * 最佳方式：三数中值分割法，即使用左端、右端和中心位置上的三个元素的中值作为枢纽元。
     * 分割策略：
     *          1.通过将枢纽元与最后的元素交换使得枢纽元离开要被分割的数据段。i 从第一个元素开始而 j 从倒数第二个元素开始
     *          2.当 i 在 j 的左边时，我们将 i 右移，移过那些小于枢纽元的元素，并将 j 左移，移过那些大于枢纽元的元素。
     *          当 i 和 j 停止时, i 指向一个大元素而 j 指向一个小元素。如果 i 在 j 左边，那么将这两个元素互换。
     *          3.重复 2 中的步骤直到 i 和 j 中的元素交错，故不再交换，分割的最后一步是将枢纽元与 i 所指向的元素交换。
     * 注意：当 i 和 j 遇到等于枢纽元的关键字，我们就让 i 和 j 都停止。
     * Time Complexity: O(nlogn)
     */
    public class QuickSortAlgorithm : ISortAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            return QuickSort(arr,0,arr.Length-1);
        }

        private int[] QuickSort(int[] arr,int left,int right)
        {
            if(left < right)
            {
                int pivot = Pivot(arr,left,right);

                int i = left;
                int j = right - 1;

                for (; ; )
                {
                    while(i<arr.Length && arr[++i] < pivot) { }

                    while(j>0 && arr[--j] > pivot) { }

                    if (i < j)
                    {
                        SortHelp.Swap(arr,i,j);
                    }
                    else
                    {
                        break;
                    }
                }
                // 把锚点交换成正确的位置
                if (i < right - 1)
                {
                    SortHelp.Swap(arr,i,right-1);
                }

                QuickSort(arr,left,i-1);

                QuickSort(arr, i + 1,right);
            }

            return arr;
        }

        private int Pivot(int[] arr,int left,int right)
        {
            int center = (left + right) / 2;
            if (arr[left] > arr[center])
            {
                SortHelp.Swap(arr,left,center);
            }
            if (arr[right] < arr[left])
            {
                SortHelp.Swap(arr,left,right);
            }
            if (arr[right] < arr[center])
            {
                SortHelp.Swap(arr,right,center);
            }
            // 如果只有三个数，那么前面的步骤已经排序
            if (left + 2 < right)
            {
                SortHelp.Swap(arr, center, right - 1);
            }
            return arr[right - 1];
        }
    }
}
