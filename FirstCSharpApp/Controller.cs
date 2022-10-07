namespace RacingConsoleApp
{
    internal class Controller
    {
        public ConsoleView View { get; }
        public RaceTrack RaceTrack { get; }

        public Controller(ConsoleView view, RaceTrack raceTrack)
        {
            View = view;
            RaceTrack = raceTrack;
        }


        public void InitController()
        {
            while (true)
            {
                View.PrintStartMenu();

                switch (View.GetStartInput())
                {
                    case ConsoleKey.Enter:
                    {
                        StartGame();
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        return;
                    }
                    case ConsoleKey.I:
                    {
                        View.PrintRules();
                        View.WaitForEscape();
                        break;
                    }
                }
                RaceTrack.NewTrack();
            }

        }


        private void StartGame()
        {
            View.PrintMemPrompt();
            ConsoleView.ShowCountdown(2);
            RaceTrack.PrintTrackMap();
            ConsoleView.ShowCountdown(5);

            foreach (var instr in RaceTrack.TrackMap)
            {
                View.PrintTurnPrompt();
                RaceTrack.Turn turn = KeyToTurn(View.GetTurnInput());

                if (instr.Item1 == turn)
                {
                    View.PrintIsCorrect(200);
                }
                else
                {
                    View.PrintGameOver(2000);
                    return;
                }

                View.PrintDistPrompt();

                if (instr.Item2 == View.GetDistInput())
                {
                    View.PrintIsCorrect(200);
                }
                else
                {
                    View.PrintGameOver(2000);
                    return;
                }
            }
        }

        private RaceTrack.Turn KeyToTurn(ConsoleKey key)
        {
            return key == ConsoleKey.LeftArrow ? RaceTrack.Turn.Left : RaceTrack.Turn.Right;
        }


    }
}
