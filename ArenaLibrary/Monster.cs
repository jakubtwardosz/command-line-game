using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaLibrary
{
    public class Monster : LivingCreature
    {
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
       
        public Monster (int id, string name, int currentHitPoints, int maximumHitPoints, int maximumDamage, int rewardExperiencePoints) : base(id, name, currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
        }
    }
}
