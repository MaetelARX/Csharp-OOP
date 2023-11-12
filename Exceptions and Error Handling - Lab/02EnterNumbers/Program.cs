using System;

class Program
{
    static int ReadNumber(int start, int end)
    {
        int number;

        while (true)
        {
            string input = Console.ReadLine();

            try
            {
                number = int.Parse(input);

                if (number <= start || number >= end)
                {
                    Console.WriteLine($"Your number is not in range {start} - {end}!");
                    continue;
                }

                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
        }
    }

    static void Main()
    {
        int[] numbers = new int[10];
        int start = 1;
        int end = 100;

        for (int i = 0; i < 10; i++)
        {
            if (i == 0)
            {
                start = 1;
            }
            else
            {
                start = numbers[i - 1];
            }

            if (i == 9)
            {
                end = 100;
            }
            else
            {
                end = end;
            }

            numbers[i] = ReadNumber(start, end);
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}