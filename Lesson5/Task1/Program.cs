int Fact(int n) // так делается только для примера. Факториал ищется через ципл for
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}

Console.Write(Fact(5));

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (до следующей точки)