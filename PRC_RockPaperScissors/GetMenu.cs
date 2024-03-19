using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    internal class GetMenu
    {
        public static void Menu()
        {
            bool inGame = true;
            while (inGame)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuMaster();

                string inputKey = Console.ReadLine();
                if (inputKey == "1") StartBattle();
                else if (inputKey == "2") GetTutorial.StartTutorial();
                else if (inputKey == "3") Settings();
                else if (inputKey == "4") Exit();
            }
        }
        public static void StartBattle()
        {
            Console.Clear();
            GetInterface.AlwaysOnScreenMenu();
            GetText.EnemyName();
            GetInterface.MenuStartBattle();
            Console.ReadKey();
            CombatSystem.Combat();
        }

        public static void Settings()
        {
            bool inGame = true;
            while (inGame)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuSettings();

                string inputKey = Console.ReadLine();
                if (inputKey == "1") ChangeName();
                else if (inputKey == "2") ClearStats();
                else if (inputKey == "4") break;
            }
        }
        public static void ChangeName()
        {
            bool inGame = true;
            bool inSet = false;
            while (inGame)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuYesNo();

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                {
                    inGame = false;
                    inSet = true;
                }
                else if (inputKey == "2") break;
            }
            while (inSet)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuChangeName();

                string tempName = Console.ReadLine();
 
                if (tempName.Length > 21)
                {
                    Console.WriteLine("\n   Name should be less then 20 symbols, try again\n\n===Press Enter===");
                    Console.ReadKey();
                }
                else if (string.IsNullOrEmpty(tempName))
                {
                    Console.WriteLine("\n   You need to write something\n\n===Press Enter===");
                    Console.ReadKey();
                }
                else
                {
                    _Master.gameValue.plName = tempName;
                    inSet = false;
                    Console.Clear();
                    GetInterface.AlwaysOnScreenMenu();
                    GetInterface.MenuChangedName();
                    Console.ReadKey();
                }
            }
        }
        public static void ClearStats()
        {
            bool inGame = true;
            bool inSet = false;
            while (inGame)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuYesNo();

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                {
                    inGame = false;
                    inSet = true;
                }
                else if (inputKey == "2") break;
            }
            while (inSet)
            {
                _Master.gameValue.countRound = 0;
                _Master.gameValue.countWin = 0;

                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuClearStat();
                inSet = false;
                Console.ReadKey();
            }
        }
        public static void Exit()
        {
            bool inGame = true;
            bool inSet = false;
            while (inGame)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuYesNo();

                string inputKey = Console.ReadLine();
                if (inputKey == "1")
                {
                    inGame = false;
                    inSet = true;
                }
                else if (inputKey == "2") break;
            }
            while (inSet)
            {
                _Master.gameValue.countRound = 0;
                _Master.gameValue.countWin = 0;

                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.MenuWeWillMissYou();
                inSet = false;

                Console.ReadKey();
                Environment.Exit(0);
            }
            
        }
    }
}
