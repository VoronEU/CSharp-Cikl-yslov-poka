using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задание (1-8):");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1: Task1(); break;
            case 2: Task2(); break;
            case 3: Task3(); break;
            case 4: Task4(); break;
            case 5: Task5(); break;
            case 6: Task6(); break;
            case 7: Task7(); break;
            case 8: Task8(); break;
            default: Console.WriteLine("Неверный номер"); break;
        }
    }

    // 1. Только одно чётное
    static void Task1()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int count = 0;
        if (a % 2 == 0) count++;
        if (b % 2 == 0) count++;
        if (c % 2 == 0) count++;

        Console.WriteLine(count == 1 ? "истина" : "ложь");
    }

    // 2. Максимум из трёх
    static void Task2()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(a, Math.Max(b, c)));
    }

    // 3. Сортировка по возрастанию
    static void Task3()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b) Swap(ref a, ref b);
        if (b > c) Swap(ref b, ref c);
        if (a > b) Swap(ref a, ref b);

        Console.WriteLine($"{a} {b} {c}");
    }

    static void Swap(ref int x, ref int y)
    {
        int t = x;
        x = y;
        y = t;
    }

    // 4. Конь
    static void Task4()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        int dx = Math.Abs(x1 - x2);
        int dy = Math.Abs(y1 - y2);

        Console.WriteLine((dx == 1 && dy == 2) || (dx == 2 && dy == 1) ? "да" : "нет");
    }

    // 5. Ферзь
    static void Task5()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        bool hit = x1 == x2 || y1 == y2 ||
                   Math.Abs(x1 - x2) == Math.Abs(y1 - y2);

        Console.WriteLine(hit ? "да" : "нет");
    }

    // 6. Проверка даты
    static void Task6()
    {
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool ok = y > 0 && m >= 1 && m <= 12 && d >= 1 && d <= DaysInMonth(m, y);
        Console.WriteLine(ok ? "корректна" : "некорректна");
    }

    // 7. Следующий день
    static void Task7()
    {
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        d++;
        if (d > DaysInMonth(m, y))
        {
            d = 1;
            m++;
            if (m > 12)
            {
                m = 1;
                y++;
            }
        }

        Console.WriteLine($"{d} {m} {y}");
    }

    // 8. Рубли
    static void Task8()
    {
        int n = int.Parse(Console.ReadLine());

        int lastTwo = n % 100;
        int last = n % 10;

        string word;
        if (lastTwo >= 11 && lastTwo <= 14)
            word = "рублей";
        else if (last == 1)
            word = "рубль";
        else if (last >= 2 && last <= 4)
            word = "рубля";
        else
            word = "рублей";

        Console.WriteLine($"{n} {word}");
    }

    static bool IsLeap(int y)
    {
        return y % 400 == 0 || (y % 4 == 0 && y % 100 != 0);
    }

    static int DaysInMonth(int m, int y)
    {
        switch (m)
        {
            case 1: case 3: case 5: case 7:
            case 8: case 10: case 12: return 31;
            case 4: case 6: case 9: case 11: return 30;
            case 2: return IsLeap(y) ? 29 : 28;
            default: return 0;
        }
    }
}
