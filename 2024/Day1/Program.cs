namespace Day1;

internal class Program
{
    private static string[] _input = File.ReadAllLines("input.txt");
    private static List<int> _leftNumbers = new();
    private static List<int> _rightNumbers = new();
    static int TotalDistance = 0;
    static int Similarity = 0;

    private static void Main()
    {
        foreach (var line in _input)
        {
            _leftNumbers.Add(int.Parse(line[..5])); // get the first 5 characters from each line
            _rightNumbers.Add(int.Parse(line[8..])); // get the last characters from each line after the white space
        }
        
        // part 1, compare the numbers and find the difference between them all.
        for (int i = 0; i < _leftNumbers.Count; i++)
        {
            int _difference = _leftNumbers[i] - _rightNumbers[i];
            _difference = Math.Abs(_difference);
            TotalDistance += _difference;
        }
        // part 2, find how many times each number appears in both lists, multiplying the first by that count.
        foreach (var set in _leftNumbers)
        {
            if (_rightNumbers.Contains(set))
            {
                Similarity += set * _rightNumbers.FindAll(c => c == set).Count;
            }
        }
        Console.WriteLine($"Similarity is: {Similarity} | Total difference is: {TotalDistance}");
    }
}