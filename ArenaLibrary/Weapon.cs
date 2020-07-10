using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaLibrary
{
    public class Weapon
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, int minimumDamage, int maximumDamage )
        {
            ID = id;
            Name = name;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

    }
}
