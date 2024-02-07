using SortingAlgorithm.BubbleSort;
using SortingAlgorithm.SortingAlgorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("================ Bubble Sort ================");
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.sort(new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

        Console.WriteLine("================ Selection Sort ================");
        SelectionSort selectionSort = new SelectionSort();
        selectionSort.sort(new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

        Console.WriteLine("================ Insertion Sort ================");
        InserctionSort inserctionSort = new InserctionSort();
        inserctionSort.sort(new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
    }

}