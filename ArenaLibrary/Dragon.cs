﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaLibrary
{
    class Dragon
    {

        // Name Health MaxAttack BlockAttack
        public string Name { get; set; } = "Rat";
        public double Health { get; set; } = 100;
        public double MaxAttack { get; set; } = 30;
        public double MaxBlock { get; set; } = 0;

        // Random numbers

        Random rnd = new Random();

        // Constructor
        public Dragon(string name = "Rat", double health = 0, double maxAttack = 0, double maxBlock = 0)
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
