using System.Reflection.Metadata.Ecma335;

namespace Hangman;

public static class GameUi
{
    public static void StartSetUp()
    {
        GameMechanics.attemptsKvar = 6;
        GameMechanics.correctSvar = string.Empty;
        GameMechanics.usedLetters = new string[28];
        GameMechanics.guessning = 0;
    }

    public static void SpelUi(string[] usedLetters, int attemptsKvar)
    {
        Console.WriteLine();
        Console.Write($" Used bokstäver: ");
        for (int i = 0; i < usedLetters.Length; i++)
        {
            Console.Write(usedLetters[i] + " ");
        }

        Console.WriteLine($"\nFörsök left: {attemptsKvar}");
        Console.WriteLine();
        Console.Write("Din guess: ");
    }
    
    public static void PrintAndUpdateMaskedWord(char[] currentOrd, string correctSvar)
    {
        for (int i = 0; i < correctSvar.Length; i++)
        {
            Console.Write(currentOrd[i] + " ");
        }
    }

    public static int ValidateGuessReturnAttempts(int attemptsKvar, string correctSvar, char förstaCharGissning, char[] currentOrd)
    {
        if (correctSvar.Contains(förstaCharGissning))
        {
            Guessningen(förstaCharGissning, currentOrd, correctSvar);
        }
        else
        {
            attemptsKvar--;
        }

        return attemptsKvar;
    }
    
    public static void Guessningen(char förstaCharGissning, char[] currentOrd, string correctSvar)
    {
        for (int i = 0; i < correctSvar.Length; i++)
        {
            if (förstaCharGissning == correctSvar[i])
            {
                currentOrd[i] = förstaCharGissning;
                
            }
        }
    }
    
    
}