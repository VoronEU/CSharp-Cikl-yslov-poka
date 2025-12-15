using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("нет");
            return;
        }

        int a = 1, b = 1;

        if (n == 1)
        {
            Console.WriteLine("да");
            return;
        }

        while (b < n)
        {
            int c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine(b == n ? "да" : "нет");
    }
}
