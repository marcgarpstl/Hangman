namespace Hangman
{
    public static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GameUi.StartSetUp();
                GameMechanics.MaskedWord();
                
                while (GameMechanics.attemptsKvar > 0)
                {
                    Console.Clear();
                    GameUi.PrintAndUpdateMaskedWord(GameMechanics.currentOrd, GameMechanics.correctSvar);
                    GameUi.SpelUi(GameMechanics.usedLetters, GameMechanics.attemptsKvar);
                    
                    var userGuess = GameMechanics.LäsLetter().ToString().ToLower();
                    if (GameMechanics.usedLetters.Contains(userGuess))
                    {
                        continue;
                    }
                    var förstaCharGissning = userGuess[0];
                    if (char.IsLetter(förstaCharGissning))
                    {
                        GameMechanics.UpdateGuessAttempt(förstaCharGissning);
                    }
                    if (string.Concat(GameMechanics.currentOrd) == GameMechanics.correctSvar)
                    {
                        GameFinnish.YouWin(GameMechanics.correctSvar);
                        break;
                    }
                    if (GameMechanics.attemptsKvar == 0)
                     Console.Clear();
                    GameFinnish.YouLose(GameMechanics.correctSvar, GameMechanics.usedLetters, GameMechanics.attemptsKvar);
                }
                GameFinnish.PlayAgain();
            }
        }
    }
}



    
    
    
        
