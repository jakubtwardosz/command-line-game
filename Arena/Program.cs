using System;
using System.Collections.Generic;
using ArenaLibrary;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Arena! Enter the name of your warrior: ");

            string name = Console.ReadLine();

            Player Hero = new Player(0, name, 20, 20, 5, 10, 1, 0);

            Console.WriteLine("Hello, {0}!", Hero.Name);

            do
            {
                PrintMenu();

                int action = int.Parse(Console.ReadLine()); // wczytaj numer polecenia
                switch (action)
                {
                    case 0:
                        Console.WriteLine("Shuting down.. ");
                        Environment.Exit(0);
                        break;
                    case 1:
                        int DifficultyLevelValue = DifficultyMenu();

                        Monster result = null;

                        switch (DifficultyLevelValue)
                        {
                            case 1:
                                result = new Monster(0, "Rat", 5, 5, 1, 5, 5, World.ITEM_ID_RUSTY_SWORD);
                                break;
                            case 2:
                                result = new Monster(1, "Knight", 15, 15, 5, 10, 15, World.ITEM_ID_CLUB);
                                break;
                            case 3:
                                result = new Monster(2, "Dragon", 20, 20, 10, 20, 20, World.ITEM_ID_WSEI_SWORD);
                                break;
                        }            
                        
                        Battle.StartFight(Hero, result);

                        break;
                    case 2:
                        Console.WriteLine("You have {0} experience points", Hero.ExperiencePoints);
                        break;
                }
            }
            while (true);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Avalible actions:");
            Console.WriteLine("\t0 - Quit");
            Console.WriteLine("\t1 - Start fighting!");
            Console.WriteLine("\t2 - Check the level of experience");
            Console.Write("Choose action: ");
        }

        private static int DifficultyMenu()
        {

            Console.WriteLine("Choose a difficulty level:");
            Console.WriteLine("\t1 - Easy");
            Console.WriteLine("\t2 - Medium");
            Console.WriteLine("\t3 - Hard");
            Console.Write("Choose action: ");

            int choice = int.Parse(Console.ReadLine());

            return choice;
        }
    }
}


