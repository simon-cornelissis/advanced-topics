static IEnumerable<int> Fibonacci(int number) 
{
    int a = 0, b = 1;
    yield return a;
    yield return b;
    for (int i = 2; i <= number; i++)
    {
        int next = a + b;
        yield return next;

        a = b;
        b = next;
    }
}

Fibonacci(10)
        .ToList()
        .ForEach(number => Console.WriteLine(number));