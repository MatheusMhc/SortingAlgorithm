using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.SortingAlgorithms
{
    internal class QuickSort : Business.SortingAlgorithm
    {
        public override void sort(int[] arrayToBeSorted)
        {
            quikSort(arrayToBeSorted,0,arrayToBeSorted.Length);
        }

        private void quikSort(int[] arrayToBeSorted, int p, int r) {

            int pivot = arrayToBeSorted.Length - 1;

            int q = partition(arrayToBeSorted, p, pivot-1, pivot);
            quikSort(arrayToBeSorted, p, q-1);
            quikSort(arrayToBeSorted, q+1, r);   
        }

        private int partition(int[] arrayToBeSorted, int left, int rigth, int pivot)
        {
            while (left < rigth)
            {
                while (left < rigth && arrayToBeSorted[left] >= arrayToBeSorted[pivot] )
                {
                    left++;
                }
                while (rigth > left && arrayToBeSorted[rigth] < arrayToBeSorted[pivot])
                {
                    rigth--;
                }

                swap(arrayToBeSorted, left, rigth);
            }

            swap(arrayToBeSorted, left, pivot);
            return left;
            //int x = arrayToBeSorted[p];
            //int i = p - 1;

            // for(int j = p; j < r-1; j++)
            //{
            //    if (arrayToBeSorted[j] <= x)
            //    {
            //        i++;
            //        swap(arrayToBeSorted, i, j);
            //    }
            //}
            // swap(arrayToBeSorted, i+1, r);
            //return i +1;
        }
    }
}
