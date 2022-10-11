

namespace RacingConsoleApp
{
    internal class ConsoleView
    {
        public ConsoleView()
        {
            InitConsole();
        }

        public ConsoleKey GetStartInput()
        {
            while (true)
            {
                ConsoleKey key;
                do
                {
                    key = Console.ReadKey(true).Key;
                } while (!IsValidStartKey(key));

                return key;
            }
        }

        public void PrintIsCorrect(int delay)
        {
            Console.WriteLine("CORRECT!");
            Thread.Sleep(delay);
            ClearKeyBuffer();
        }

        public void PrintStartMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome To The Game!");
            Console.WriteLine("____________________\n");
            Console.WriteLine("Press Enter To Start The game\n");
            Console.WriteLine("Press ESC to quit\n");
            Console.WriteLine("Press I for info about the game\n");
            Console.WriteLine("Press H to honk you car");
        }

        private void InitConsole()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "AMAZING RACING GAME!";
            Console.CursorVisible = false;
        }

        private bool IsValidStartKey(ConsoleKey key)
        {
            return key is ConsoleKey.Enter or ConsoleKey.Escape or ConsoleKey.I or ConsoleKey.H;
        }


        public void PrintMemPrompt()
        {
            Console.Clear();
            Console.WriteLine("MEMORIZE THE INSTRUCTIONS!");
        }

        public void PrintTurnPrompt()
        {
            Console.Clear();
            Console.WriteLine("Press -> to turn RIGHT");
            Console.WriteLine("Press <- to turn LEFT");
        }

        public ConsoleKey GetTurnInput()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (!IsLeftOrRightKey(key));

            return key;
        }

        public void PrintDistPrompt()
        {
            Console.Clear();
            Console.WriteLine("Input meters to drive: ");
        }

        public int GetDistInput()
        {
            Console.CursorVisible = true;
            string? input;
            int n;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out n));

            Console.CursorVisible = false;

            return n;
        }


        public void PrintGameOver(int delay)
        {
            Console.Clear();
            Console.WriteLine("Game Over, You Lose!");
            Thread.Sleep(delay);
            ClearKeyBuffer();
        }

        public void PrintYouWin(int delay)
        {
            Console.Clear();
            Console.WriteLine("Congratulations! You Won!");
            Thread.Sleep(delay);
            ClearKeyBuffer();
        }

        public static bool IsLeftOrRightKey(ConsoleKey key)
        {
            return key == ConsoleKey.RightArrow | key == ConsoleKey.LeftArrow;
        }


        public static void ShowCountdown(int sec)
        {
            Console.WriteLine();
            Console.WriteLine("Seconds left:");
            for (var i = sec; i >= 1; i--)
            {
                Console.Write("\r{0:00}", i);
                Thread.Sleep(1000);
            }

            Console.Write("\rTIME'S UP!");
            Thread.Sleep(1000);
            ClearKeyBuffer();
        }

        public static void ClearKeyBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
        }


        public void WaitForEscape()
        {
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        public void PrintRules()
        {
            Console.Clear();
            Console.WriteLine("Try to memorize the directions before the timer runs out!");
            Console.WriteLine("When prompted: Make the correct turns and drive the correct distances to win!");
            Console.WriteLine("Press ESC to go back.");
        }

    }
}
