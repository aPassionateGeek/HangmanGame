



namespace Hangman
{
    class Programm
    {
        static void Main(string[] args)
        {
            char[] badsigns = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '\\', '|', ';', ':', '\'', '"', ',', '<', '.', '>', '/', '?', ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.WriteLine("\u001b[1mWelcome to Hangman!\u001b[0m");
            Console.WriteLine("\u001b[1mPlease enter a word to guess: \u001b[0m");
            Console.WriteLine("Note: The word should not contain any special characters or numbers.");
            string wordToGuess = Console.ReadLine().ToLower();
            Console.Clear();
            string hiddenWord = new string('_', wordToGuess.Length);
            int attemptsLeft = 6;

            if (wordToGuess.Length == 0 || wordToGuess.Any(c => badsigns.Contains(c)))
            {
                Console.WriteLine("Invalid input! Please enter a valid word.");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }

            while (attemptsLeft > 0 && hiddenWord.Contains('_'))
            {
                Console.WriteLine($"Word: {hiddenWord}");
                Console.WriteLine($"Attempts left: {attemptsLeft}");
                Console.WriteLine("Guess a letter or the word:");
                string guess = Console.ReadLine().ToLower();
                char guessedLetter = guess[0];
                Console.Clear();

                if (guess == wordToGuess)
                {
                    hiddenWord = wordToGuess;
                }
                if (wordToGuess.Contains(guessedLetter))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guessedLetter)
                        {
                            hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guessedLetter.ToString());
                        }
                    }
                }
                else
                {
                    attemptsLeft--;
                    Console.WriteLine($"Incorrect guess! You have {attemptsLeft} attempts left.");
                    Console.WriteLine(Galgen(attemptsLeft));
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey(); Console.Clear();
                }
            }
            if (!hiddenWord.Contains('_'))
            {
                Console.WriteLine($"Congratulations! You've guessed the word: {wordToGuess}");
                Console.WriteLine("Press any key to try again, or press Backspace to close...");
                if (Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    Environment.Exit(0);
                }
                Console.ReadKey(); Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine($"Game over! The word was: {wordToGuess}");
            }




        }

        static string Galgen(int fehler)
        {
            return fehler switch
            {
                6 => "  +---+\n  |   |\n      |\n      |\n      |\n      |\n=========",
                5 => "  +---+\n  |   |\n  O   |\n      |\n      |\n      |\n=========",
                4 => "  +---+\n  |   |\n  O   |\n  |   |\n      |\n      |\n=========",
                3 => "  +---+\n  |   |\n  O   |\n /|   |\n      |\n      |\n=========",
                2 => "  +---+\n  |   |\n  O   |\n /|\\  |\n      |\n      |\n=========",
                1 => "  +---+\n  |   |\n  O   |\n /|\\  |\n /    |\n      |\n=========",
                0 => "  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |\n=========",
            };
        }

    }
}
