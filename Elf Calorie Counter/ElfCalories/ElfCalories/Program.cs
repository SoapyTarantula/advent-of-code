internal class Program
{
    private static void Main()
    {
        List<int> _topThree = new List<int>();
        List<int> _numBlock;
        List<int> _nums = new List<int>();
        List<List<int>> _listOfLists = new List<List<int>>();
        string[] lines = System.IO.File.ReadAllLines("elf_calories.txt");

        // Get lines from text file, convert to integer.
        foreach (var item in lines)
        {
            if (!string.IsNullOrEmpty(item))
            {
                _nums.Add(Convert.ToInt32(item));
            }
            else
            // Use the whitespace/linebreaks in the file to signal a new elf is being checked, throw him into the wheelbarrow of fatness and reset the nums list.
            {
                _numBlock = new List<int>(_nums);
                _listOfLists.Add(_numBlock);
                _nums.Clear();
            }
        }
        // Add the fat boys to the list of fattest fats.
        foreach (var item in _listOfLists)
        {
            _topThree.Add(item.Sum());
        }
        // Get the three fattest elves and combine their fatness into one catastrophically fat number.
        _topThree.Sort();
        _topThree.Reverse();
        int newTotal = _topThree[0] + _topThree[1] + _topThree[2];
        Console.WriteLine($"The fattest elf is carrying {_topThree[0]} calories.");
        Console.WriteLine($"The three fattest elves are carrying a combined {newTotal} calories.");
    }
}