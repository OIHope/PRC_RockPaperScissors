using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    class CombatSystem
    {
        Random random = new Random();
        public static void Combat()
        {
            int countRound;
            int countPlayerWin;
            int countEnemyWin;
            



            while ((_Master.playerStat.combatRoundCount <= 3)||(_Master.playerStat.combatPlayerWinCount > 1)||(_Master.playerStat.combatEnemyWinCount > 1))
            {
                
                string enemyWeaponID = EnemyWeaponCheck();
                string playerWeaponID = PlayerWeaponCheck();
                CombatCheck(playerWeaponID, enemyWeaponID);
                
            }
        }
        static string EnemyWeaponCheck()
        {
            Random rand = new Random();
            int i = rand.Next(0, 3);
            string enemyWeaponID = "";
            switch (i)
            {
                case 0:
                    enemyWeaponID = "rock";
                    break;
                case 1:
                    enemyWeaponID = "paper";
                    break;
                case 2:
                    enemyWeaponID = "scissors";
                    break;
            }
            GetText.EnemyWeaponResponce(enemyWeaponID);
            return enemyWeaponID;
        }
        static string PlayerWeaponCheck()
        {
            string playerWEaponID = "";
            bool temp = true;
            while(temp)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreen();
                GetInterface.CubeStart();
                GetInterface.CombatEnemyLog();
                GetInterface.CombatPLayerPrompt();
                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                {
                    playerWEaponID = "rock";
                    temp = false;
                }
                else if (inputKey == "2")
                {
                    playerWEaponID = "paper";
                    temp = false;
                }
                else if (inputKey == "3")
                {
                    playerWEaponID = "scissors";
                    temp = false;
                }
            }
            
            return playerWEaponID;
        }
        static void CombatCheck(string playerWeaponID, string enemyWeaponID)
        {
            if ((playerWeaponID == "rock") && (enemyWeaponID == "rock"))
                RockVsRock();
            else if ((playerWeaponID == "rock") && (enemyWeaponID == "paper"))
                RockVsPaper();
            else if ((playerWeaponID == "rock") && (enemyWeaponID == "scissors"))
                RockVsScissors();
            else if ((playerWeaponID == "paper") && (enemyWeaponID == "rock"))
                PaperVsRock();
            else if ((playerWeaponID == "paper") && (enemyWeaponID == "paper"))
                PaperVsPaper();
            else if ((playerWeaponID == "paper") && (enemyWeaponID == "scissors"))
                PaperVsScissors();
            else if ((playerWeaponID == "scissors") && (enemyWeaponID == "rock"))
                ScissorsVsRock();
            else if ((playerWeaponID == "scissors") && (enemyWeaponID == "paper"))
                ScissorsVsPaper();
            else if ((playerWeaponID == "scissors") && (enemyWeaponID == "scissors"))
                ScissorsVsScissors();
        }
        static void RockVsRock()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeRockRock();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundDraw();
        }
        static void RockVsPaper()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeRockPaper();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundEnemyWin();
        }
        static void RockVsScissors()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeRockScissors();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundPlayerWin();
        }
        static void PaperVsRock()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubePaperRock();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundPlayerWin();
        }
        static void PaperVsPaper()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubePaperPaper();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundDraw();
        }
        static void PaperVsScissors()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubePaperScissors();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundEnemyWin();
        }
        static void ScissorsVsRock()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeScissorsRock();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundEnemyWin();
        }
        static void ScissorsVsPaper()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeScissorsPaper();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundPlayerWin();
        }
        static void ScissorsVsScissors()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeScissorsScissors();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            RoundDraw();
        }
        static void RoundPlayerWin()
        {

            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeWinLose();
            GetText.Responce("win");
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            if ((_Master.playerStat.combatPlayerWinCount == 2) || (_Master.playerStat.combatRoundCount == 3))
                GamePlayerWin();
            else
                _Master.playerStat.combatPlayerWinCount++;
                _Master.playerStat.combatRoundCount++;

        }
        static void RoundEnemyWin()
        {


            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeLoseWin();
            GetText.Responce("lose");
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            if ((_Master.playerStat.combatEnemyWinCount ==2)||(_Master.playerStat.combatRoundCount == 3))
                GameAIWin();
            else
                _Master.playerStat.combatEnemyWinCount++;
                _Master.playerStat.combatRoundCount++;
}
        static void RoundDraw()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeDraw();
            GetText.Responce("draw");
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();
        }
        static void GamePlayerWin()
        {
            _Master.playerStat.countWin++;
            _Master.playerStat.countRound++;
            bool temp = true;
            while (temp)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreen();
                GetInterface.CubePlayerWin();
                GetText.Responce("win");
                GetInterface.CombatEnemyLog();
                GetInterface.CombatPLayerPromptEndRound();
                _Master.playerStat.combatRoundCount = 1;
                _Master.playerStat.combatPlayerWinCount = 0;

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                    temp = false;
                else if (inputKey == "2")
                {
                    temp = false;
                    Console.Clear();
                    GetMenu.Menu();
                }
            }
            
        }
        static void GameAIWin()
        {
            _Master.playerStat.countRound++;

            bool temp = true;
            while (temp)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreen();
                GetInterface.CubePlayerLose();
                GetText.Responce("lose");
                GetInterface.CombatEnemyLog();
                GetInterface.CombatPLayerPromptEndRound();
                _Master.playerStat.combatRoundCount = 1;
                _Master.playerStat.combatEnemyWinCount = 0;

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                    temp = false;
                else if (inputKey == "2")
                {
                    temp = false;
                    Console.Clear();
                    GetMenu.Menu();
                }
            }
            
        }
    }
    
}
