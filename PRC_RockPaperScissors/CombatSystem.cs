using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    // ЩО ЗРОБИТИ!
    //
    // система бою передбачатиме, що гравець зможе вгадати наступний крок суперника через опис.
    // ШІ буде завжди першим обирати "зброю", а тому виводимо повідомлення типу "Суперник дивиться на вас (прикметник\ознака) очима"
    // або "Суперник кинув на вас (прикметник\ознака) погляд"
    // і таким чином можна здогадатись що викине суперник. для кожного треба буде декілька схожих варіацій
    // наприклад для ножиць: гострий погляд, посмішка з гострими зубами і тд
    // це додасть момент скілу та знання гри, а не рандому, де можна просто затикать однією комбінацією

    // інтерфейс має завжди бути зверху
    // там буде назва гри, розлення якесь
    // загальна статистика з іменем гравця і бла бла бла
    // розділення і тут робимо вікно бою, яке має містити імя гравця, та імя суперника (імена останнього треба буде рандомно нагенерувати)
    // вікно бою робимо горизонтально, два віконця, праве для гравця, ліве для суперника. віконця невеликі
    // над віконцями  між іменами гравців будемо вести лог битви, де буде записано кть раундів
    // над самими віконцями будемо малювати якісь символи як в МК що показуватимуть кть перемог. можливо це зробимо між віконцями, хз
    // перша фаза бою ми показуємо у віконці суперника знак питання, бо ми не знаємо що там
    // у віконці гравця показуємо три міні іконки каменю, паперу, ножиць і під кожним підпис типу (1) Камінь (2) Папір ...
    // під цими віконцями у нас буде лог, де записуватимемо реакцію суперника (те що описано вище про його вибір)
    // а також зробимо поле вибору, де вписуватимемо число щоб обрати "зброю"
    //
    // після того як обрали число прожимаємо ентер і у обох віконцях виводимо READY та чекаємо натиск кнопки ще раз
    // потім вже відкриваємо хто що обрав
    // ще раз тиснемо ентер щоб отримати результат. його вписуємо у віконця (LOSE, WIN, DRAW)
    // нічиї за раунд не рахуються
    //
    //після перемоги чи програшу протискаємо ентер і отримуємо повідомлення в лог від суперника, а віконця очищаються (забагато варіацій малювати)
    //
    //в ідеалі робити все так, щоб консоль постійно очищалась і відмальовувалась заново, щоб все відбувалось на одному листі, а не на скатертині
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
            _Master.playerStat.combatRoundCount++;
            _Master.playerStat.combatPlayerWinCount++;
            Console.ReadKey();
        }
        static void RoundEnemyWin()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeLoseWin();
            GetText.Responce("lose");
            GetInterface.CombatEnemyLog();
            GetInterface.CombatPLayerPromptBreak();
            _Master.playerStat.combatRoundCount++;
            _Master.playerStat.combatEnemyWinCount++;
            Console.ReadKey();
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

        }
        static void GameAIWin()
        {

        }
        static void GameDraw()
        {

        }
    }
    
}
