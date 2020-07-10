using System;

namespace ArenaLibrary
{
    public class Battle
    {



        /*public static string GetAttackResult(Player player, Monster monster)
        {
            *//*Weapon currentWeapon = (Weapon)player.CurrentWeapon;*/




           /* int damageToMonster = RandomNumberGenerator.NumberBetween(Player.c);*//*


        }*/

        /*// Start Fight
        // WarriorA WarriorB
        public static void StartFight(Player warriorA, Monster monster)
        {

            // Loop giving warrior a chance to attack and block each turn until 1 dies

            while (true)
            {
                if (GetAttackResult(warriorA, monster) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }

        }
        // GetAttackResult
        // Warrior1, Warriotr2

        public static string GetAttackResult(Player warrior1, Monster monster)
        {
            double warrior1AttAmt = warrior1.Attack();
            double monsterBlkAmt = monster.Block();

            double dmgTomonster = warrior1AttAmt - monsterBlkAmt;

            if (dmgTomonster > 0)
            {
                monster.Health = monster.Health - dmgTomonster;
            }
            else dmgTomonster = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warrior1.Name, monster.Name, dmgTomonster);

            Console.WriteLine("{0} Has {1} Health \n", monster.Name, monster.Health);

            // death
            if (monster.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is victorius \n", monster.Name, warrior1.Name);
                return "Game Over";
            }
            else return "Fight again";

        }*/




        


        
    }
}
