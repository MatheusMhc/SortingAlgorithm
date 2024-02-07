using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.BubbleSort
{
    internal class BubbleSort : Business.SortingAlgorithm
    {

        public override void sort(int[] arrayToBeSorted)
        {
            for (int i = 0; i < arrayToBeSorted.Length; i++)
            {
                for (int j = 1; j < arrayToBeSorted.Length; j++)
                {
                    if (arrayToBeSorted[j - 1] > arrayToBeSorted[j])
                    {
                        swap(arrayToBeSorted, j - 1, j);
                    }
                }
            }

            printArray(arrayToBeSorted);
        }

    }
}
