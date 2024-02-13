using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    public class Sort
    {
        public static void QuickSort<T>(T[] array, Comparison<T> comparison) 
        {
            QuickSortInternal(array, 0, array.Length - 1, comparison);
        }

        private static void QuickSortInternal<T>(T[] array, int left, int right, Comparison<T> comparison)
        {
            if (left >= right)
            {
                return;
            }

            int partition = PartitionInternal(array, left, right, comparison);

            QuickSortInternal(array, left, partition - 1, comparison);
            QuickSortInternal(array, partition + 1, right, comparison);
        }

        private static int PartitionInternal<T>(T[] list, int left, int right, Comparison<T> comparison) 
        {
            T partition = list[right];

            // stack items smaller than partition from left to right
            int swapIndex = left;
            for (int i = left; i < right; i++)
            {
                T item = list[i];
                if (comparison(item,partition) <= 0)
                {
                    list[i] = list[swapIndex];
                    list[swapIndex] = item;

                    swapIndex++;
                }
            }

            // put the partition after all the smaller items
            list[right] = list[swapIndex];
            list[swapIndex] = partition;

            return swapIndex;
        }
    }
}
