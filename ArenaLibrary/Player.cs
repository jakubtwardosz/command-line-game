using System;
using System.Collections.Generic;

namespace ArenaLibrary
{
    public class Player : LivingCreature
    {
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }

        public List<Weapon> Weapons = new List<Weapon>();

        public Player(int id, string name, int currentHitPoints, int maximumHitPoints, int minimumDamage, int maximumDamage, int level, int experiencePoints) : base (id, name, currentHitPoints, maximumHitPoints, minimumDamage, maximumDamage)
        {
            Level = level;
            ExperiencePoints = experiencePoints;
        }
    }
}



