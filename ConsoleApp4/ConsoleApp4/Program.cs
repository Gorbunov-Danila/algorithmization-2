using System;
class HelloWorld
{
    static int Counter = 0;
    static void Main()
    {
        Console.WriteLine("[System] Введите число A: ");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("[System] Введите число B: ");
        int B = int.Parse(Console.ReadLine());
        var Timer = DateTime.Now;
        Console.WriteLine($@"[System] НОД числа {A} и {B} = " + GCD(A, B).ToString());
        Console.WriteLine($@"[System] Количество выполнения: {Counter}");
        Console.WriteLine("[System] Время выполнения: " + DateTime.Now.Subtract(Timer).TotalSeconds.ToString());
    }
    static int GCD(int a, int b)
    {
        if (a == 0) { Counter++; return b; }
        else if (b == 0) { Counter++; return a; }
        else if (a >= b) { Counter++; return GCD(a % b, b); }
        else { Counter++; return GCD(a, b % a); }
    }
}
