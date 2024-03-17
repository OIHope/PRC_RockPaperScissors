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
            int countRound = 1;
            int countWin = 0;
            while ((countRound <= 3) || (countWin != 2))
            {
                
            }
        }
        static int PlayerWeaponCheck()
        {
            int playerWeaponID = 0;
            return playerWeaponID;
        }
        static int AIWeaponCheck()
        {
            int AIWeaponID = 0;
            return AIWeaponID;
        }
        static void RockVsRock(int playerWeaponID, int AIWeaponID)
        {
            RoundDraw();
        }
        static void RockVsPaper(int playerWeaponID, int AIWeaponID)
        {
            RoundAIWin();
        }
        static void RockVsScissars(int playerWeaponID, int AIWeaponID)
        {
            RoundPlayerWin();
        }
        static void PaperVsRock(int playerWeaponID, int AIWeaponID)
        {
            RoundPlayerWin();
        }
        static void PaperVsPaper(int playerWeaponID, int AIWeaponID)
        {
            RoundDraw();
        }
        static void PaperVsScissars(int playerWeaponID, int AIWeaponID)
        {
            RoundAIWin();
        }
        static void ScissarsVsRock(int playerWeaponID, int AIWeaponID)
        {
            RoundAIWin();
        }
        static void ScissarsVsPaper(int playerWeaponID, int AIWeaponID)
        {
            RoundPlayerWin();
        }
        static void ScissarsVsScissars(int playerWeaponID, int AIWeaponID)
        {
            RoundDraw();
        }
        static void RoundPlayerWin()
        {
            
        }
        static void RoundAIWin()
        {

        }
        static void RoundDraw()
        {

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
