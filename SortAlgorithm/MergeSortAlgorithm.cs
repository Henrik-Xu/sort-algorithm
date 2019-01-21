using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /*
     * Merge Sort（归并排序）
     * Merge Sort is a Divide and Conquer algorithm. It divides input array in two halves, calls itself for the two halves and then merges the two sorted halves.
     * Time Complexity: O(nlogn)
     */
    public class MergeSortAlgorithm : ISortAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            return MergeSort(arr);
        }

        private int[] MergeSort(int[] arr)
        {
            int length = arr.Length;
            if (length == 1)
            {
                return arr;
            }

            int middle = length / 2 ;
            int[] left = new int[middle];
            int[] right = new int[length - middle];

            for (int i = 0; i < middle; i++)
            {
                left[i] = arr[i];
            }
            for (int i = middle; i < length; i++)
            {
                right[i - middle] = arr[i];
            }

            left = MergeSort(left);

            right = MergeSort(right);

            return Merge(left,right);
        }

        private int[] Merge(int[] left ,int[] right)
        {
            int leftLen = left.Length;
            int rightLen = right.Length;

            int[] newArr = new int[leftLen+rightLen];
            int indexLeft = 0;
            int indexRight = 0;
            int indexResult = 0;

            while (indexLeft<leftLen || indexRight<rightLen)
            {
                 if(indexLeft<leftLen && indexRight < rightLen)
                 {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        newArr[indexResult] = left[indexLeft];
                        indexLeft++;
                    }
                    else
                    {
                        newArr[indexResult] = right[indexRight];
                        indexRight++;
                    }
                 }
                else if (indexLeft < leftLen)
                {
                    newArr[indexResult] = left[indexLeft];
                    indexLeft++;
                }
                else
                {
                    newArr[indexResult] = right[indexRight];
                    indexRight++;
                }
                
                indexResult++;
            }

            return newArr;
        }
    }
}
