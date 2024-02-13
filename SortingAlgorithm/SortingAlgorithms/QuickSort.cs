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
            quikSort(arrayToBeSorted,0,arrayToBeSorted.Length-1);
            printArray(arrayToBeSorted);
        }

        private void quikSort(int[] arrayToBeSorted, int p, int r) {
            if(p < r)
            {
                int pivot = r;

                int q = partition(arrayToBeSorted, p, r, pivot);
                quikSort(arrayToBeSorted, p, q-1);
                quikSort(arrayToBeSorted, q + 1, r);
            }
            
        }

        private int partition(int[] arrayToBeSorted, int left, int rigth, int pivot)
        {

            int i = left - 1;
            for(int j = left; j <= rigth; j++)
            {
                if (arrayToBeSorted[j] < arrayToBeSorted[pivot])
                {
                    i++;
                    swap(arrayToBeSorted, i,j);
                }
            }

            swap(arrayToBeSorted, i + 1, rigth);
            return i + 1;

        }
    }
}
