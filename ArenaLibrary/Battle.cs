using System;

namespace ArenaLibrary
{
    public class Battle
    {
        // Start Fight
        // WarriorA WarriorB
        public static void StartFight(Warrior warriorA, Warrior warriorB)
        {

            // Loop giving warrior a chance to attack and block each turn until 1 dies

            while (true)
            {
                if (GetAttackResult(warriorA, warriorB) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warriorB, warriorA) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }

        }
        // GetAttackResult
        // Warrior1, Warriotr2

        public static string GetAttackResult(Warrior warrior1, Warrior warrior2)
        {
            double warrior1AttAmt = warrior1.Attack();
            double warrior2BlkAmt = warrior2.Block();

            double dmgToWarrior2 = warrior1AttAmt - warrior2BlkAmt;

            if (dmgToWarrior2 > 0)
            {
                warrior2.Health = warrior2.Health - dmgToWarrior2;
            }
            else dmgToWarrior2 = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warrior1.Name, warrior2.Name, dmgToWarrior2);

            Console.WriteLine("{0} Has {1} Health \n", warrior2.Name, warrior2.Health);

            // death
            if (warrior2.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is victorius \n", warrior2.Name, warrior1.Name);
                return "Game Over";
            }
            else return "Fight again";

        }




        


        
    }
}
