using System.Reflection.Metadata;

namespace Hangman;

public static class GameFinnish
{
    public static void YouLose(string correctSvar, string [] usedLetters, int attemptsKvar)
    {
        GameUi.PrintAndUpdateMaskedWord(GameMechanics.currentOrd, GameMechanics.correctSvar);
        Console.WriteLine();
        Console.Write($" Used letters: ");
        for (int i = 0; i < usedLetters.Length; i++)
        {
            Console.Write(usedLetters[i] + " ");
        }

        Console.WriteLine($"\nTries left: {attemptsKvar}");
        Console.WriteLine();
        Console.WriteLine("No more chances, you lost. Deal with it! ");

        Console.WriteLine($"The correct word was: {correctSvar}");
            
    }

    public static void YouWin(string correctSvar)
    {

        Console.Clear();
        for (int i = 0; i < correctSvar.Length; i++)
        {
            Console.Write(correctSvar[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Correct word: {correctSvar} !!");

        Console.WriteLine("You won, WordHunterProGuessMofo!");
    }
    
    public static void PlayAgain()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to play again? [N]o or [Y]es");
            var jaNo = Console.ReadLine().ToLower();
            if (jaNo == "y")
                break;
            if (jaNo == "n")
            {
                Console.Clear();
                Console.Write("Aaah, too bad, I bet it was too hard.");
                Environment.Exit(0);
            }

            {
                Console.Clear();
                Console.Write("Invalid choice");
                Console.WriteLine();
            }
        }
    }
}