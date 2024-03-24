using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    public class GameValue
    {
        public string plName = "";
        public int plAge;

        public string enemyName = "";
        public string enemyResponce = "";

        public int countRound = 0;
        public int countWin = 0;

        public int combatRoundCount = 1;
        public int combatPlayerWinCount = 0;
        public int combatEnemyWinCount = 0;
        public int combatDrawCount = 0;
    }
}
