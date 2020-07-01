using System;

namespace ArenaLibrary
{
    public class Warrior
    {
        // Name Health MaxAttack BlockAttack
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double MaxAttack { get; set; } = 0;
        public double MaxBlock { get; set; } = 0;

        // Random numbers

        Random rnd = new Random();

        // Constructor
        public Warrior(string name = "Warrior", double health = 0, double maxAttack = 0, double maxBlock = 0)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
        }

        // Attack 
        // Generate a random attack from 1
        // to the maximum attack 
        public double Attack()
        {
            return rnd.Next(1, (int)MaxAttack);
        }


        // Block
        // Generate a random block from 1
        // to the maximum block

        public double Block()
        {
            return rnd.Next(1, (int)MaxBlock);
        }

    }
}
