using System;
using ArenaLibrary;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Arena!");

            Warrior maximus = new Warrior("maximus", 1000, 120, 40);

            Warrior bob = new Warrior("bob", 1000, 120, 40);

            Battle.StartFight(maximus, bob);

            Console.ReadLine();
        }
    }
}
