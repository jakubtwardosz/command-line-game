using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaLibrary
{
    class DifficultyLevel
    {
        private Monster currentMonster;

        public void SelectDifficultyLevel (int difficulty)
        {
            if (difficulty == 0)
            {
                currentMonster = World.MonsterByID(1);
            }
            else if (difficulty == 1)
            {
                currentMonster = World.MonsterByID(2);
            }
            else if (difficulty == 2)
            {
                currentMonster = World.MonsterByID(3);
            }
        }
    }
}
