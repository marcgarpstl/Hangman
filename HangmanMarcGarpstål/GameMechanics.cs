namespace Hangman;

public class GameMechanics
{
    public static char[] currentOrd;
    public static int attemptsKvar;
    public static string correctSvar;
    public static string[] usedLetters;
    public static int guessning;
    private static string[] WordBank = 
    {
        "hängdman",
        "kaffesump",
        "nitroglycerin",
        "stockholm",
        "herkules",
        "afrodite",
        "monark",
        "diplomat",
        "president",
        "sverige",

    };

    public static string RandomWordGenerator()
    {
        Random slump = new Random();
        return WordBank[slump.Next(0, WordBank.Length)];
    }
    
    public static void ConvertAndPrint(char[] currentOrd,string correctSvar)
    {
        for (int i = 0; i < correctSvar.Length; i++)
        {
            currentOrd[i] = '_';
            Console.Write(currentOrd[i] + " ");
        }
    }
    
    public static char LäsLetter()
    {
        char bokstav = default;
        while (true)
        {
            var keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Enter && bokstav != default)
                return bokstav;
            if (keyInfo.Key == ConsoleKey.Backspace)
                return default;
            if (char.IsLetter(keyInfo.KeyChar) && bokstav == default)
            {
                bokstav = keyInfo.KeyChar;
                Console.Write(bokstav);
            }
        }
    } // Inläsning av _en_ bokstav samt möjlighet att använda backspace
    
    public static void LäsGissning(string[] usedLetters, int guessning, char förstaCharGissning)
    {
        usedLetters[guessning] = förstaCharGissning.ToString();
    } // Hardcore method! Beware!!_!!_!

    public static void MaskedWord()
    {
        correctSvar = RandomWordGenerator();
        currentOrd = new char[correctSvar.Length];
        ConvertAndPrint(currentOrd, correctSvar);
    }
    
    public static void UpdateGuessAttempt(char förstaCharGissning)
    {
         LäsGissning(usedLetters, guessning, förstaCharGissning);
            guessning++;
            attemptsKvar = GameUi.ValidateGuessReturnAttempts(attemptsKvar, correctSvar, förstaCharGissning, currentOrd);
    }

    
}