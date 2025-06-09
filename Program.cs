using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a single letter: ");
        char input = Char.ToLower(Console.ReadKey().KeyChar); 
        Console.WriteLine();

        string result = CheckLetterType(input);
        Console.WriteLine(result);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string CheckLetterType(char letter)
    {
        if (!Char.IsLetter(letter))
        {
            return "That's not a valid letter.";
        }
        else if ("aeiou".Contains(letter))
        {
            return $"{letter} is a vowel.";
        }
        else
        {
            return $"{letter} is a consonant.";
        }
    }
}

    
