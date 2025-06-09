using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a single letter: ");
        char input = Char.ToLower(Console.ReadKey().KeyChar); 
        Console.WriteLine(); 

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
