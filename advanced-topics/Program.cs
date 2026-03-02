using ClassLibrary;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>();
        fruits.Add("banana");
        fruits.Add("apple");
        fruits.Add("kiwi");

        Func<string, string>
            capitalize = s => s.ToUpper();

        Console.WriteLine(capitalize(fruits[0]));

        Func<string, int>
            counter = s => s.Length;

        Func<string, string, bool>
            compared = (s, c) => s.Length == c.Length || s.Equals(c);

        Func<string, string>
            alphabetically = s => 
            {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            };

        //Ex 6



    }
}