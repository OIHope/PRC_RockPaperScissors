using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    public class PlayerStat
    {
        public string plName = "";
        public int plAge;

        public bool canPlay = true;
        public bool watchTutorial = false;

        public string enemyName = "";

        public int countRound;
        public int countWin;
    }
}
