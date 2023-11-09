using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first 9 digits of the ISBN: ");
        string input = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int digit = int.Parse(input[i].ToString());
            sum += (10 - i) * digit;
        }
        int checkDigit = 11 - (sum % 11);
        string isbn = input + (checkDigit == 10 ? "X" : checkDigit.ToString());
        Console.WriteLine($"The ISBN-10 with the check digit is:{isbn} ");
    }
}