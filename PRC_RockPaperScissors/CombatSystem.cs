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
            CombatStatClear();

            bool inGame = true;
            while (inGame)
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

            _Master.gameValue.combatPlayerWinCount++;
            GetText.Responce("win");

            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeWinLose();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            WinnerCheck();
        }
        static void RoundEnemyWin()
        {
            _Master.gameValue.combatEnemyWinCount++;
            GetText.Responce("lose");

            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeLoseWin();
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            Console.ReadKey();

            WinnerCheck();
}
        static void RoundDraw()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeDraw();
            GetText.Responce("draw");
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            _Master.gameValue.combatDrawCount++;
            Console.ReadKey();

            WinnerCheck();
        }
        static void WinnerCheck()
        {
            bool gameOn = true;

            if (_Master.gameValue.combatRoundCount == 1)
                gameOn = true;
            if (_Master.gameValue.combatRoundCount == 2)
            {
                if (_Master.gameValue.combatPlayerWinCount == 2)
                {
                    GetText.Responce("win");
                    gameOn = false;
                    GamePlayerWin();
                }
                else if (_Master.gameValue.combatEnemyWinCount == 2)
                {
                    GetText.Responce("lose");
                    gameOn = false;
                    GameAIWin();
                }
                else
                    gameOn = true;
            }
            if (_Master.gameValue.combatRoundCount == 3)
            {
                if (_Master.gameValue.combatPlayerWinCount > _Master.gameValue.combatEnemyWinCount)
                {
                    GetText.Responce("win");
                    gameOn = false;
                    GamePlayerWin();
                }
                else if (_Master.gameValue.combatEnemyWinCount > _Master.gameValue.combatPlayerWinCount)
                {
                    GetText.Responce("lose");
                    gameOn = false;
                    GameAIWin();
                }
                else if (_Master.gameValue.combatPlayerWinCount == _Master.gameValue.combatEnemyWinCount)
                {
                    GetText.Responce("draw");
                    gameOn = false;
                    GameDraw();
                }
            }
            if (gameOn)
                _Master.gameValue.combatRoundCount++;
        }
        static void GamePlayerWin()
        {
            _Master.gameValue.countWin++;
            _Master.gameValue.countRound++;

            bool temp = true;
            while (temp)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreen();
                GetInterface.CubePlayerWin();
                GetInterface.CombatEnemyLog();
                GetInterface.CombatPLayerPromptEndRound();

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                    temp = false;
                else if (inputKey == "2")
                {
                    temp = false;
                    CombatStatClear();
                    Console.Clear();
                    GetMenu.Menu();
                }
            }
            CombatStatClear();

        }
        static void GameAIWin()
        {

            _Master.gameValue.countRound++;

            bool temp = true;
            while (temp)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreen();
                GetInterface.CubePlayerLose();
                GetInterface.CombatEnemyLog();
                GetInterface.CombatPLayerPromptEndRound();

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                    temp = false;
                else if (inputKey == "2")
                {
                    temp = false;
                    CombatStatClear();
                    Console.Clear();
                    GetMenu.Menu();
                }
            }
            CombatStatClear();
        }
        static void GameDraw()
        {

            _Master.gameValue.countRound++;

            bool temp = true;
            while (temp)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreen();
                GetInterface.CubeGameDraw();
                GetInterface.CombatEnemyLog();
                GetInterface.CombatPLayerPromptEndRound();

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                    temp = false;
                else if (inputKey == "2")
                {
                    temp = false;
                    CombatStatClear();
                    Console.Clear();
                    GetMenu.Menu();
                }
            }
            CombatStatClear();
        }
        static void CombatStatClear()
        {
            _Master.gameValue.combatPlayerWinCount = 0;
            _Master.gameValue.combatEnemyWinCount = 0;
            _Master.gameValue.combatRoundCount = 1;
            _Master.gameValue.combatDrawCount = 0;
        }
    }
    
}
