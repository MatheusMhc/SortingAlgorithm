using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.SortingAlgorithms
{
    internal class MergeSort : Business.SortingAlgorithm
    {
        public override void sort(int[] arrayToBeSorted)
        {
            printArray(mergeSort(arrayToBeSorted));
        }

        private int[] mergeSort(int[] arrayToBeSorted)
        {
            if (arrayToBeSorted.Length == 1) return arrayToBeSorted;

            int half = arrayToBeSorted.Length / 2;

            var firstPart = arrayToBeSorted.Take(half).ToArray();
            var secondPart = arrayToBeSorted.Skip(half).Take(half + 1).ToArray();

      
            return merge(mergeSort(firstPart), mergeSort(secondPart));
        }

        private int[] merge(int[] firstArray, int[] secondArray)
        {
            int i = 0;
            int[] tempArrayOrded = new int[firstArray.Length + secondArray.Length];

            while(firstArray.Length > 0 &&  secondArray.Length > 0)
            {
                if (firstArray[0] > secondArray[0])
                {
                    tempArrayOrded[i] = secondArray[0];
                    secondArray = secondArray.Skip(1).Take(secondArray.Length).ToArray();
                    i++;
                } else {
                    tempArrayOrded[i] = firstArray[0];
                    firstArray = firstArray.Skip(1).Take(firstArray.Length).ToArray();
                    i++;
                }
            }

            while(firstArray.Length > 0)
            {
                tempArrayOrded[i] = firstArray[0];
                firstArray = firstArray.Skip(1).Take(firstArray.Length).ToArray();
                i++;
            }

            while (secondArray.Length > 0)
            {
                tempArrayOrded[i] = secondArray[0];
                secondArray = secondArray.Skip(1).Take(secondArray.Length).ToArray();
                i++;
            }

            return tempArrayOrded;
        }

    }
}
