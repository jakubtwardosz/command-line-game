using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaLibrary
{
    public class Monster : LivingCreature
    {
        public int RewardExperiencePoints { get; set; }

        public int RewardWeapon { get; set; }
       
        public Monster (int id, string name, int currentHitPoints, int maximumHitPoints, int minimumDamage, int maximumDamage, int rewardExperiencePoints, int rewardWeapon) : base(id, name, currentHitPoints, maximumHitPoints, minimumDamage, maximumDamage)
        {
            RewardExperiencePoints = rewardExperiencePoints;
            RewardWeapon = rewardWeapon;
        }
    }
}
