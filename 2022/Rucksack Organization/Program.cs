using System.Text;

internal class Program
{
    private static void Main()
    {
        //char[] lowercase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<string> _firstHalf = new List<string>();
        List<string> _secondHalf = new List<string>();
        List<char> _firstLetters = new List<char>();
        List<char> _secondLetters = new List<char>();
        List<string> test = new List<string>();
        string[] input = File.ReadAllLines("..\\..\\..\\bags.txt");

        int fart = 0;

        foreach (var bag in input)
        {
            _firstHalf.Add(bag.Substring(0, bag.Length / 2));
            _secondHalf.Add(bag.Substring(bag.Length / 2));
        }
    }
}