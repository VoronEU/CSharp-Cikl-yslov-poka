using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int n = Math.Abs(number);
        int reversed = 0;

        while (n > 0)
        {
            reversed = reversed * 10 + n % 10;
            n /= 10;
        }

        if (number < 0)
            reversed = -reversed;

        Console.WriteLine(reversed);
    }
}
