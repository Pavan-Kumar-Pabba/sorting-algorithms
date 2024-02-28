/*
Author: Pavan Kumar Pabba
This C# Console Application code demonstrates the Selection Sort.
No input is required for the script. 
It will execute without input against two pre-populated arrays. 
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 72, 3, 14, 7, 1 };  // unsorted list of elements
        Console.WriteLine("Unsorted array:");
        PrintArray(arr);
        SelectionSort(arr);
        Console.WriteLine("\nAfter Execution Selection sort the Sorted array is :");
        PrintArray(arr);
    }
    static void SelectionSort(int[] arr)
{
    int n = arr.Length; // Get the length of the array
    for (int i = 0; i < n - 1; i++) // Loop through the array from index 0 to n-2
    {
        int minIndex = i; // Assume the current index as the minimum index
        for (int j = i + 1; j < n; j++) // Loop through the unsorted part of the array
        {
            if (arr[j] < arr[minIndex]) // If we find a smaller element
            {
                minIndex = j; // Update the minimum index
            }
        }
        // Swap arr[i] and arr[minIndex]
        int temp = arr[i]; // Store the current element in a temporary variable
        arr[i] = arr[minIndex]; // Replace the current element with the minimum element found
        arr[minIndex] = temp; // Place the current element in the position of the minimum element
    }
}
    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
