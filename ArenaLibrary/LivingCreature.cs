using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaLibrary
{
    public class LivingCreature 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public LivingCreature(int id, string name, int currentHitPoints, int maximumHitPoints, int minimumDamage, int maximumDamage)
        {
            ID = id;
            Name = name;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
