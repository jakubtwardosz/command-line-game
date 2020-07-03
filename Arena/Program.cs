using System;
using ArenaLibrary;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Arena!");
            
            

            

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result:");
                    break;
                case "a":
                    Console.WriteLine($"Your result:");
                    break;
                case "a":
                    Console.WriteLine($"Your result:");
                    break;
                case "a":
                    Console.WriteLine($"Your result:");
                    break;

            }



        }

        private static void PrintMenu()
        {
            Console.WriteLine("Avalible actions:");
            Console.WriteLine("\t1 - Choose a difficulty level");
            Console.WriteLine("\t2 - Check your items");
            Console.WriteLine("\t3 - Check the level of experience");
            Console.WriteLine("\t4 - Start fighting!");
            Console.WriteLine("\t5 - Hall of Fame");
            Console.Write("Choose action: ");
        }

        private static NewPlayer()
        {
            Console.WriteLine("Enter the name of your warrior: ");

            Warrior player = new Warrior(Console.ReadLine());

            Console.WriteLine("Hello, {0}!", player.Name);

            return player;

        }
    }
}
