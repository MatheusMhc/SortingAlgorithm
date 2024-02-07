using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.SortingAlgorithms
{
    internal class SelectionSort : Business.SortingAlgorithm
    {
        public override void sort(int[] arrayToBeSorted)
        {
            int smallestIndex;

            for (int i = 0; i < arrayToBeSorted.Length; i++)
            {
                smallestIndex = i;
                for (int j = i + 1; j < arrayToBeSorted.Length; j++)
                {
                    if (arrayToBeSorted[j] < arrayToBeSorted[smallestIndex]) smallestIndex = j;
                }

                if (smallestIndex != i) swap(arrayToBeSorted, smallestIndex, i);
            }


            printArray(arrayToBeSorted);
        }
    }
}
