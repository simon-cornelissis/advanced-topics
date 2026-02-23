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

static string Reverse(string text)
{
    if (string.IsNullOrEmpty(text))
        return text;
    return text[^1] + Reverse(text[..^1]);
}

Console.WriteLine("Please enter a text: ");
string myText = Console.ReadLine().Trim().ToLower();

string myReversedText = Reverse(myText);

Console.WriteLine(myReversedText);
	
Console.WriteLine($"The text {myText} is { (myText == myReversedText ? "a" : "not a")} palindrome"); 