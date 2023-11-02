using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid array size.");
            return;
        }

        int[] originalArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            originalArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Original Array:");
        PrintArray(originalArray);

        int[] newArray = RemoveDuplicates(originalArray);

        Console.WriteLine("New Array:");
        PrintArray(newArray);
    }
       static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int[] RemoveDuplicates(int[] array)
    {
        int newCount = 0;
        int[] newArray = new int[array.Length];

        foreach (int element in array)
        {
            bool isDuplicate = false;

            for (int i = 0; i < newCount; i++)
            {
                if (element == newArray[i])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                newArray[newCount] = element;
                newCount++;
            }
        }
        Array.Resize(ref newArray, newCount);
        return newArray;
    }
}
