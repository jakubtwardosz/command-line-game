using System;
using System.Collections.Generic;

namespace ArenaLibrary
{
    public class Player : LivingCreature
    {
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<Weapon> Inventory { get; set; }

        public Player(int id, string name, int currentHitPoints, int maximumHitPoints, int level, int experiencePoints) : base (id, name, currentHitPoints, maximumHitPoints)
        {
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<Weapon>();
        }
    }
}
