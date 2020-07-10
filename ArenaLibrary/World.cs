using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaLibrary
{
    public class World
    {
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Weapon> Weapons = new List<Weapon>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_CLUB = 2;
        public const int ITEM_ID_WSEI_SWORD = 3;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_KNIGHT = 2;
        public const int MONSTER_ID_DRAGON = 3;

        static World()
        {
            GenerateWeapons();
            GenerateMonsters();
        }

        private static void GenerateWeapons()
        {
            Weapons.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", 5, 10));
            Weapons.Add(new Weapon(ITEM_ID_CLUB, "Club", 10, 15));
            Weapons.Add(new Weapon(ITEM_ID_WSEI_SWORD, "WSEI sword", 15, 20));
        }

        private static void GenerateMonsters()
        {            
            Monsters.Add(new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 10));
            Monsters.Add(new Monster(MONSTER_ID_KNIGHT, "Knight", 5, 3, 10, 10));
            Monsters.Add(new Monster(MONSTER_ID_DRAGON, "Dragon", 5, 3, 10, 10));
        }

        public static Weapon WeaponByID(int id)
        {
            foreach (Weapon weapon in Weapons)
            {
                if (weapon.ID == id)
                {
                    return weapon;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }
    }
}
