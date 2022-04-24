// See https://aka.ms/new-console-template for more information
namespace RPSLogic
{
    internal class Program
    {
        public int Player1Wins;
        public int Player2Wins;

        private int Choice()
        {
            int choice;
            string input = "";

            Console.WriteLine("Enter the number of your choice:\n1. Rock\n2. Paper\n3. Scisors\n");
            input = Console.ReadLine();

            choice = Convert.ToInt32(input);
            
            return choice;
        }
        private void Round()
        {
            int player1 = Choice();
            int player2 = Choice();

            while (player1 == player2)
            {
                Console.WriteLine("Tie!");
                player1 = Choice();
                player2 = Choice();
            }

            if ((player1 == 1 && player2 == 3))
            {
                Player1Wins++;
                Console.WriteLine("\nRound to Player 1!\nScore:\n P1: " + Player1Wins + "\n P2: " + Player2Wins);
            }
            else if (player1 > player2)
            {
                Player1Wins++;
                Console.WriteLine("\nRound to Player 1!\nScore:\n P1: " + Player1Wins + "\n P2: " + Player2Wins);
            }
            else
            {
                Player2Wins++;
                Console.WriteLine("\nRound to Player 2!\nScore:\n P1: " + Player1Wins + "\n P2: " + Player2Wins);
            }
        }
        public string Game()
        {
            Player1Wins = 0;
            Player2Wins = 0;
            while (Player1Wins != 3 && Player2Wins != 3)
            {
                Round();
            }
            if (Player1Wins >= 3)
                return "Player one Wins!";
            else
                return "Player two Wins!";

        }
        static void Main(String[] args)
        {
            Program RockPaperScisiors = new Program();
            Console.WriteLine(RockPaperScisiors.Game());
        }
    }
}