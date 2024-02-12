using SortingAlgorithm.BubbleSort;
using SortingAlgorithm.SortingAlgorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        var watch = new System.Diagnostics.Stopwatch();

        Console.WriteLine("================ Bubble Sort ================");
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.sort(new int[8] { 14, 33, 27, 10, 35, 19, 42, 44 });

        Console.WriteLine("================ Selection Sort ================");
        SelectionSort selectionSort = new SelectionSort();
        selectionSort.sort(new int[8] { 14, 33, 27, 10, 35, 19, 42, 44 });

        Console.WriteLine("================ Insertion Sort ================");
        InserctionSort inserctionSort = new InserctionSort();
        inserctionSort.sort(new int[8] { 14, 33, 27, 10, 35, 19, 42, 44 });

        Console.WriteLine("================ Merge Sort ================");
        MergeSort mergeSort = new MergeSort();
        mergeSort.sort(new int[8] { 14,33,27,10,35,19,42,44 });

        Console.WriteLine("================ Quick Sort ================");
        QuickSort quickSort = new QuickSort();
        quickSort.sort(new int[8] { 14, 33, 27, 10, 35, 19, 42, 44 });
    }

}