using System;
public class HelloWorld
{
    public static long Counter = 0;
    public static void Main(string[] args)
    {
        Console.WriteLine("[Program] Введите число: ");
        int N = int.Parse(Console.ReadLine());
        var Timer = DateTime.Now;
        Console.WriteLine("[Program] Результат: " + FibRecursive(N).ToString());
        Console.WriteLine("[Program] Количество выполнений: " + Counter.ToString());
        Console.WriteLine("[Program] Время выполнения: " + DateTime.Now.Subtract(Timer).TotalSeconds + " сек.");
    }
    static int FibRecursive(int Number)
    {
        Counter++;
        if (Number <= 1) return Number;
        else return FibRecursive(Number - 1) + FibRecursive(Number - 2);
    }
}
