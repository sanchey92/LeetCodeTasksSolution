using System.Collections.Generic;

namespace LeetCodeTasks.Library;

public static class BraceBalance
{
    private static readonly Dictionary<char, char> Pairs = new()
    {
        { '{', '}' },
        { '(', ')' },
        { '[', ']' }
    };

    public static bool IsBalanced(string text)
    {
        if (string.IsNullOrEmpty(text)) return false;

        var stackOfChars = new Stack<char>();

        foreach (var symbol in text)
        {
            if (Pairs.ContainsKey(symbol)) stackOfChars.Push(symbol);

            else if (!Pairs.ContainsValue(symbol)) continue;

            else if (stackOfChars.Count == 0) return false;

            else if (Pairs[stackOfChars.Pop()] != symbol) return false;
        }

        return stackOfChars.Count == 0;
    }
}