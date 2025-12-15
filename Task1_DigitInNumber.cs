using System;

class Program
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int digit = int.Parse(Console.ReadLine());

        bool found = false;

        if (number == 0 && digit == 0)
            found = true;

        while (number > 0)
        {
            if (number % 10 == digit)
            {
                found = true;
                break;
            }
            number /= 10;
        }

        Console.WriteLine(found ? "да" : "нет");
    }
}
