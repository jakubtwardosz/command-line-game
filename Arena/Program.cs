using System;
using System.Collections.Generic;
using ArenaLibrary;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Arena!");

            Console.WriteLine("Enter the name of your warrior: ");

            string name = Console.ReadLine();

            Player newPlayer = new Player(0, name, 10, 10, 1, 0);

            Console.WriteLine("Hello, {0}!", newPlayer.Name);

            newPlayer.Inventory.Add(new Weapon(World.ITEM_ID_RUSTY_SWORD, "Rusty sword", 5, 10));

            Console.WriteLine("At the beginning you received a Rusty Sword!");            

            foreach (Weapon item in newPlayer.Inventory)
            {
                Console.WriteLine(item.Name);
            }

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
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
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
            Console.WriteLine("\t2 - Check your items");
            Console.WriteLine("\t3 - Check the level of experience");
            Console.WriteLine("\t4 - Choose a difficulty level");
            Console.Write("Choose action: ");
        }
        

    }
}
