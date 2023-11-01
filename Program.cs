using System;

class Program
{
    static void Main()
    {
        string[] duodecimal = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"};

        Console.Write("Enter the first integer: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine("The range between the two integers is ");
            for (int i = A; i <= B; i++)
            {
                if (i >= 0 && i <= 11)
                {
                    Console.Write(duodecimal[i] + " ");
                }
            }
    }
}