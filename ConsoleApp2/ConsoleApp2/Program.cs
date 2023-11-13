using System;
public class HelloWorld
{
    public static int Counter = 0;
    public static void Main(string[] args)
    {
        Console.WriteLine("[Program] Введите число: ");
        int N = int.Parse(Console.ReadLine());
        var Timer = DateTime.Now;
        Console.WriteLine("[Program] Результат: " + FibArray(N).ToString());
        Console.WriteLine("[Program] Количество выполнений: " + Counter.ToString());
        Console.WriteLine("[Program] Время выполнения: " + DateTime.Now.Subtract(Timer).TotalSeconds + " сек.");
    }
    static int FibArray(int Number)
    {
        int[] Array = new int[Number + 1];
        Array[0] = 0;
        Array[1] = 1;
        for (int i = 2; i <= Number; i++) { Counter++; Array[i] = Array[i - 1] + Array[i - 2]; }
        return Array[Number];
    }
}