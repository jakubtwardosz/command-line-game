using System;

namespace command_line_game
{
    class Program
    {
        static String[] board = new String[9];

        static void initializeVariable()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = i.ToString();
            }
        }




        static void Main(string[] args)
        {
            initializeVariable();
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
            drawBoard();
            int selection = Convert.ToInt32(Console.ReadLine());

            board[selection] = player;
        }

        static void drawBoard()
        {

            for (int i = 0; i < 9; i += 3) 
                Console.WriteLine(board[i] + "|" + board[i + 1] + "|" + board[i + 2]);


        }

        static Boolean hasWon()
        {
            for (int i = 0; i < 7; i+=3)
            {
                if (board[i].Equals(board[i + 1]) && board[i + 1].Equals(board[i + 2]))

                    return true;

            }
            if (board[0].Equals(board[3]) && board)
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
