using System;

namespace ArenaLibrary
{
    public class Battle
    {
        public static void StartFight(LivingCreature a, LivingCreature b)
        {
            while (true)
            {
                if (GetAttackResult(a, b) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult(LivingCreature a, LivingCreature b)
        {
            int damageToCreature = RandomNumberGenerator.NumberBetween(a.MinimumDamage, a.MaximumDamage);

            if (damageToCreature > 0)
            {
                b.CurrentHitPoints = b.CurrentHitPoints - damageToCreature;
            }
            else damageToCreature = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", a.Name, b.Name, damageToCreature);

            Console.WriteLine("{0} Has {1} Health \n", b.Name, b.CurrentHitPoints);

            // death
            if (b.CurrentHitPoints <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is victorius \n", b.Name, a.Name);
                return "Game Over";
            }
            else return "Fight again";

        }
    }
}
