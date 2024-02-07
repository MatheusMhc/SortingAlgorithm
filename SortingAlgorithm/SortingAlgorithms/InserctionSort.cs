using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.SortingAlgorithms
{
    internal class InserctionSort : Business.SortingAlgorithm
    {
        public override void sort(int[] arrayToBeSorted)
        {
            for (int i = 0; i < arrayToBeSorted.Length; i++)
            {
               int key = arrayToBeSorted[i];
               int j = i - 1;

                while (j >= 0 && arrayToBeSorted[j] > key)
                {
                    arrayToBeSorted[j + 1] = arrayToBeSorted[j];
                    j--;
                }

                arrayToBeSorted[j + 1] = key;

            }


            printArray(arrayToBeSorted);
        }
    }
}
