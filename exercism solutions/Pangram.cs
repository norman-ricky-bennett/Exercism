using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        var character = 'a';
        while (character <= 'z')
        {
            if (!input.ToLower().Contains(character)) return false;
            character++;
        }

        return true;
    }
}
