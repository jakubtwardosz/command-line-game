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
    
        public LivingCreature(int id, string name, int currentHitPoints, int maximumHitPoints)
        {
            ID = id;
            Name = name;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
    }
}
