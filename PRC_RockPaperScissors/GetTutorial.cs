using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    class GetTutorial
    {
        public static void StartTutorial()
        {
            _Master.playerStat.watchTutorial = true;
            GetMenu.Menu();
        }
    }
}
