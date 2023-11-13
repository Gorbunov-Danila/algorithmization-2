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
        Console.WriteLine($@"[System] НОД числа {A} и {B} = " + NaiveGCD(A, B).ToString());
        Console.WriteLine($@"[system] Количество выполнений: {Counter}");
        Console.WriteLine("[System] Время выполнения: " + DateTime.Now.Subtract(Timer).TotalSeconds.ToString());
    }
    static int NaiveGCD(int a, int b)
    {
        int GCD = 1;
        for (int d = 2; d < Math.Max(a, b); d++) { Counter++; if (a % d == 0 && b % d == 0) GCD = d; }
        return GCD;
    }
}