using System;
using System.Collections.Generic;
using ArenaLibrary;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Player hero = new Player(0,"Warrior", 20, 20, 5, 10, 1, 0);
            Monster monster = new Monster(0, "Monster", 5, 5, 1, 5, 10);

            Battle.StartFight(hero, monster);


        }
    }
}
