using System;

namespace command_line_game
{
    class Program
    {
        int[] board = new int[9];

        static void Main(string[] args)
        {
            introduction();
            while (hasWon() == false)
            {
                askData("X");
                if (hasWon() == true)
                    break;
                askData("0");
            }          
        }

        static void askData(String player)
        {
            Console.WriteLine("Player: " + player);
            Console.WriteLine("Please enter your selection.");
            int selection = Convert.ToInt32(Console.ReadLine());
        }

        static void drawBoard()
        {

        }

        static Boolean hasWon()
        {
            return false;
        }

        static void introduction()
        {
            Console.Title = "Kółko i krzyżyk";
            Console.WriteLine("Witaj w grze kółko i krzyżyk!");
            Console.WriteLine("Wciśnij jakiś klawisz... ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
