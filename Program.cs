using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a single letter: ");
        char input = Char.ToLower(Console.ReadKey().KeyChar); 
        Console.WriteLine(); 

        Console.WriteLine($"Reverted letter: {RevertCase(input)}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

static char RevertCase(char c) =>
        Char.IsLetter(c) ? (Char.IsLower(c) ? Char.ToUpper(c) : Char.ToLower(c)) : c;
}
