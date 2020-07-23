/*Given an Array array_A , Write a program to count no of times a number is repeated. */
using System;

class GFG
{

    static void printRepeating(int []arr, int size)
    {
        int i, j;

        Console.Write("Repeated Elements are :");
        for (i = 0; i < size; i++)
        {
            for (j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                    Console.Write(arr[i] + " ");
            }
        }
    }
    // driver code
    public static void Main()
    {
        int []arr = {4, 2, 4, 5, 2, 3, 1};
        int arr_size = arr.Length;

        printRepeating(arr, arr_size);
    }
}
