using System;


namespace Client
{
    internal class GamePlayInput
    {
        public static string Choice()
        {
            int choice;
            String choiceString;
            string input = "";

            Console.WriteLine("Enter the number of your choice:\n1. Rock\n2. Paper\n3. Scisors\n");
            input = Console.ReadLine();

            choice = Convert.ToInt32(input);

            if (choice == 1)
                return "Rock<EOF>";
            else if (choice == 2)
                return "Paper<EOF>";
            else if (choice == 3)
                return "Scissors<EOF>";
            else
                return "Invalid Choice";
        }
        
    }
}
