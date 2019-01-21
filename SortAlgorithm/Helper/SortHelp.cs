using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class SortHelp
    {
        public static void Swap(int[] arr, int preIndex, int nextIndex)
        {
            int temp = arr[preIndex];
            arr[preIndex] = arr[nextIndex];
            arr[nextIndex] = temp;
        }

        public static int[] HelperSort(ISortAlgorithm algorithm, int[] unsorted)
        {
            return algorithm.Sort(unsorted);
        }
    }
}
