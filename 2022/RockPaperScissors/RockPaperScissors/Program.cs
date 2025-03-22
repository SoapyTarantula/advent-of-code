internal class Program
{
    private static int ScoreTotal = 0;
    private static void Main()
    {
        // Variables and file input.
        string[] _input = File.ReadAllLines("input.txt");
        List<char> opponentMove = new List<char>();
        List<char> defenseMove = new List<char>();

        // Separate opponent moves from our own.
        foreach (var item in _input)
        {
            // Get the first digit and the third digit from the string array.
            opponentMove.Add(item[0]);
            defenseMove.Add(item[2]);
        }
        // A & X are rock.
        // B & Y are paper.
        // C & Z are scissors.

        // Part 2 introduces new rules.
        // X means lose.
        // Y means draw.
        // Z means win.

        for (int i = 0; i < _input.Length; i++)
        {
            // if statements will carry me safely to my grave.
            if (opponentMove[i] == 'A')
            {
                if (defenseMove[i] == 'X') { ScoreTotal += Loss('Z'); }
                if (defenseMove[i] == 'Y') { ScoreTotal += Draw('X'); }
                if (defenseMove[i] == 'Z') { ScoreTotal += Win('Y'); }
            }
            if (opponentMove[i] == 'B')
            {
                if (defenseMove[i] == 'X') { ScoreTotal += Loss('X'); }
                if (defenseMove[i] == 'Y') { ScoreTotal += Draw('Y'); }
                if (defenseMove[i] == 'Z') { ScoreTotal += Win('Z'); }
            }
            if (opponentMove[i] == 'C')
            {
                if (defenseMove[i] == 'X') { ScoreTotal += Loss('Y'); }
                if (defenseMove[i] == 'Y') { ScoreTotal += Draw('Z'); }
                if (defenseMove[i] == 'Z') { ScoreTotal += Win('X'); }
            }
        }
        Console.WriteLine(ScoreTotal);
    }

    private static int Win(char _move)
    {
        int num = 6;
        if(_move == 'X') { num += 1; }
        if(_move == 'Y') { num += 2; }
        if(_move == 'Z') { num += 3; }
        Console.WriteLine("Win.");
        return num;
    }

   private static int Draw(char _move)
    {
        int num = 3;
        if(_move == 'X') { num += 1; }
        if(_move == 'Y') { num += 2; }
        if(_move == 'Z') { num += 3; }
        Console.WriteLine("Draw.");
        return num;
    }

   private static int Loss(char _move)
    {
        int num = 0;
        if (_move == 'X') { num += 1; }
        if (_move == 'Y') { num += 2; }
        if (_move == 'Z') { num += 3; }
        Console.WriteLine("Loss.");
        return num;
    }
}