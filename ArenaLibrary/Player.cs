using System;
using System.Collections.Generic;

namespace ArenaLibrary
{
    public class Player : LivingCreature
    {
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public List<Weapon> Inventory { get; set; }

        public Player(int id, string name, int currentHitPoints, int maximumHitPoints, int level, int experiencePoints, int minimumDamage, int maximumDamage) : base (id, name, currentHitPoints, maximumHitPoints)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<Weapon>();
        }
    }
}
