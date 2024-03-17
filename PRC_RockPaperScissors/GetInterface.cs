using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    public class GetInterface
    {
        public static void ScreenSize()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|           title                                                                                      |");
            Console.WriteLine("|           t                                                                                          |");
            Console.WriteLine("|           t                                                                                          |");
            Console.WriteLine("|           t                                                                                          |");
            Console.WriteLine("|           t                                                                                          |");
            Console.WriteLine("|           t                                                                                          |");
            Console.WriteLine("|           t                                                                                          |");
            Console.WriteLine("|           t                                                                                          |");
            Console.WriteLine("|        player info                                                                                   |\n");
            Console.WriteLine("|                                           game info round                                            |");
            Console.WriteLine("|              player name                                            enemy name                       |\n");
            Console.WriteLine("|   ----------------------------------------------------------------------------------                 |\n\n\n\n\n\n\n\n");
            Console.WriteLine("|                                FOR BETTER EXPERIENCE RESISE YOU WINDOW                               |");
            Console.WriteLine("|                                             TO THE LINES                                             |");
            Console.WriteLine("|                                       OR MAKE IT FULL SCREEN                                         |\n");
            Console.WriteLine("|                                                                                                      |\n\n\n\n\n\n\n\n");
            Console.WriteLine("|    -------------------------------------------------------------------------------------             |\n");
            Console.WriteLine("|          round result log                                                                            |\n");
            Console.WriteLine("|          enemy prompt                                                                                |\n");
            Console.WriteLine("|      ===  CHOOSE  ===                                                                                |\n");
            Console.WriteLine("|      1 play again      2 back to menu                                                                |\n");
            Console.WriteLine("|      player write here                                                                               |\n");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");




            Console.ReadKey();
            Console.Clear();
        }
        //покищо це лише задум, але відтвоювати частини інтерфейсу типу тайтлу і тд можна через окремий клас
        //наприклад щоб не створювати кожен раз методи в кожному з класів, повторювані частини інтерфейсу створювати тут
        public static void WelcomeTitle1()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("     ███╗ ██████╗          ██████╗ ██╗    ██████╗ ██████╗  ██████╗ ██████╗          ██████╗ ███╗");
            Console.WriteLine("     ██╔╝██╔═══██╗        ██╔═══██╗██║    ██╔══██╗██╔══██╗██╔═══██╗██╔══██╗        ██╔═══██╗╚██║");
            Console.WriteLine("     ██║ ██║██╗██║        ██║   ██║██║    ██████╔╝██████╔╝██║   ██║██║  ██║        ██║██╗██║ ██║");
            Console.WriteLine("     ██║ ██║██║██║        ██║   ██║██║    ██╔═══╝ ██╔══██╗██║   ██║██║  ██║        ██║██║██║ ██║");
            Console.WriteLine("     ███╗╚█║████╔╝        ╚██████╔╝██║    ██║     ██║  ██║╚██████╔╝██████╔╝        ╚█║████╔╝███║");
            Console.WriteLine("     ╚══╝ ╚╝╚═══╝          ╚═════╝ ╚═╝    ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═════╝          ╚╝╚═══╝ ╚══╝");


            Console.ReadKey();
            Console.Clear();

        }
        public static void WelcomeTitle2()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                               ██████╗  ██████╗  ██████╗██╗  ██╗     ");
            Console.WriteLine("                               ██╔══██╗██╔═══██╗██╔════╝██║ ██╔╝    ");
            Console.WriteLine("                               ██████╔╝██║   ██║██║     █████╔╝      ");
            Console.WriteLine("                               ██╔══██╗██║   ██║██║     ██╔═██╗   ");
            Console.WriteLine("                               ██║  ██║╚██████╔╝╚██████╗██║  ██╗    ");
            Console.WriteLine("                               ╚═╝  ╚═╝ ╚═════╝  ╚═════╝╚═╝  ╚═╝          ");
            Console.WriteLine("                            ██████╗  █████╗ ██████╗ ███████╗██████╗ ");
            Console.WriteLine("                            ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗      ");
            Console.WriteLine("                            ██████╔╝███████║██████╔╝█████╗  ██████╔╝        ");
            Console.WriteLine("                            ██╔═══╝ ██╔══██║██╔═══╝ ██╔══╝  ██╔══██╗     ");
            Console.WriteLine("                            ██║     ██║  ██║██║     ███████╗██║  ██║        ");
            Console.WriteLine("                            ╚═╝     ╚═╝  ╚═╝╚═╝     ╚══════╝╚═╝  ╚═╝           ");
            Console.WriteLine("                 ███████╗ ██████╗██╗███████╗███████╗ ██████╗ ██████╗ ███████╗");
            Console.WriteLine("                 ██╔════╝██╔════╝██║██╔════╝██╔════╝██╔═══██╗██╔══██╗██╔════╝");
            Console.WriteLine("                 ███████╗██║     ██║███████╗███████╗██║   ██║██████╔╝███████╗");
            Console.WriteLine("                 ╚════██║██║     ██║╚════██║╚════██║██║   ██║██╔══██╗╚════██║");
            Console.WriteLine("                 ███████║╚██████╗██║███████║███████║╚██████╔╝██║  ██║███████║");
            Console.WriteLine("                 ╚══════╝ ╚═════╝╚═╝╚══════╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝");
            Console.ReadKey();
            Console.Clear();

        }
        public static void TitleNoInfo()
        {
            Console.WriteLine("   ███╗███╗            ███╗███╗        ██████╗ ██████╗ ███████╗        ███╗███╗            ███╗███╗");
            Console.WriteLine("   ╚██║╚██║            ██╔╝██╔╝        ██╔══██╗██╔══██╗██╔════╝        ╚██║╚██║            ██╔╝██╔╝");
            Console.WriteLine("    ██║ ██║█████╗█████╗██║ ██║         ██████╔╝██████╔╝███████╗         ██║ ██║█████╗█████╗██║ ██║ ");
            Console.WriteLine("    ██║ ██║╚════╝╚════╝██║ ██║         ██╔══██╗██╔═══╝ ╚════██║         ██║ ██║╚════╝╚════╝██║ ██║ ");
            Console.WriteLine("   ███║███║            ███╗███╗        ██║  ██║██║     ███████║        ███║███║            ███╗███╗");
            Console.WriteLine("   ╚══╝╚══╝            ╚══╝╚══╝        ╚═╝  ╚═╝╚═╝     ╚══════╝        ╚══╝╚══╝            ╚══╝╚══╝");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        }
        public static void AlwaysOnScreenMenu()
        {
            Console.WriteLine("   ███╗███╗            ███╗███╗        ██████╗ ██████╗ ███████╗        ███╗███╗            ███╗███╗");
            Console.WriteLine("   ╚██║╚██║            ██╔╝██╔╝        ██╔══██╗██╔══██╗██╔════╝        ╚██║╚██║            ██╔╝██╔╝");
            Console.WriteLine("    ██║ ██║█████╗█████╗██║ ██║         ██████╔╝██████╔╝███████╗         ██║ ██║█████╗█████╗██║ ██║ ");
            Console.WriteLine("    ██║ ██║╚════╝╚════╝██║ ██║         ██╔══██╗██╔═══╝ ╚════██║         ██║ ██║╚════╝╚════╝██║ ██║ ");
            Console.WriteLine("   ███║███║            ███╗███╗        ██║  ██║██║     ███████║        ███║███║            ███╗███╗");
            Console.WriteLine("   ╚══╝╚══╝            ╚══╝╚══╝        ╚═╝  ╚═╝╚═╝     ╚══════╝        ╚══╝╚══╝            ╚══╝╚══╝");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("     Player Name: " + _Master.playerStat.plName + 
                "     Player Age: " + _Master.playerStat.plAge + 
                "     Rounds Played: " + _Master.playerStat.countRound + 
                "     Wins: " + _Master.playerStat.countWin);
        }
        public static void AlwaysOnScreen()
        {
            Console.WriteLine("   ███╗███╗            ███╗███╗        ██████╗ ██████╗ ███████╗        ███╗███╗            ███╗███╗");
            Console.WriteLine("   ╚██║╚██║            ██╔╝██╔╝        ██╔══██╗██╔══██╗██╔════╝        ╚██║╚██║            ██╔╝██╔╝");
            Console.WriteLine("    ██║ ██║█████╗█████╗██║ ██║         ██████╔╝██████╔╝███████╗         ██║ ██║█████╗█████╗██║ ██║ ");
            Console.WriteLine("    ██║ ██║╚════╝╚════╝██║ ██║         ██╔══██╗██╔═══╝ ╚════██║         ██║ ██║╚════╝╚════╝██║ ██║ ");
            Console.WriteLine("   ███║███║            ███╗███╗        ██║  ██║██║     ███████║        ███║███║            ███╗███╗");
            Console.WriteLine("   ╚══╝╚══╝            ╚══╝╚══╝        ╚═╝  ╚═╝╚═╝     ╚══════╝        ╚══╝╚══╝            ╚══╝╚══╝");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("     Player Name: " + _Master.playerStat.plName +
                "     Player Age: " + _Master.playerStat.plAge +
                "     Rounds Played: " + _Master.playerStat.countRound +
                "     Wins: " + _Master.playerStat.countWin+"\n");
            Console.WriteLine($" Round: (round number)");
            Console.WriteLine($"     {_Master.playerStat.plName}: (Wins in round)          Enemy name: (wins in round)");
        }
        public static void MenuMaster()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("======Main Menu======");
            Console.WriteLine("");
            Console.WriteLine("(1) Start Battle");
            Console.WriteLine("");
            Console.WriteLine("(2) Tutorial");
            Console.WriteLine("(3) Settings");
            Console.WriteLine("");
            Console.WriteLine("(4) Exit");
            Console.WriteLine("");
            Console.WriteLine("-----Write here----");
        }
        public static void MenuStartBattle()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("======Main Menu======");
            Console.WriteLine("");
            Console.WriteLine("So the battle begins!");
            Console.WriteLine("");
            Console.WriteLine($"Your opponent will be: {_Master.playerStat.enemyName}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=====Press Enter=====");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void MenuSettings()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("======Main Menu======");
            Console.WriteLine("");
            Console.WriteLine("======Settings");
            Console.WriteLine("");
            Console.WriteLine("(1) Change name");
            Console.WriteLine("(2) Clear statistics");
            Console.WriteLine("");
            Console.WriteLine("(4) Go back");
            Console.WriteLine("");
            Console.WriteLine("-----Write here----");
        }
        public static void MenuChangeName()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("======Main Menu======");
            Console.WriteLine("");
            Console.WriteLine("======Change Name");
            Console.WriteLine("");
            Console.WriteLine("Write you new name");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----Write here----");
        }
        public static void MenuChangedName()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("======Main Menu======");
            Console.WriteLine("");
            Console.WriteLine("=Your name is changed");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----Press Enter----");
        }
        public static void MenuClearStat()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("======Main Menu======");
            Console.WriteLine("");
            Console.WriteLine("=Your statistics is cleared");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("(4) Go back");
            Console.WriteLine("");
            Console.WriteLine("-----Write here----");
        }
        public static void MenuYesNo()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=Are you sure?");
            Console.WriteLine("");
            Console.WriteLine("(1) Yes");
            Console.WriteLine("(2) No");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----Write here----");
        }
        public static void MenuWeWillMissYou()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=We will miss you!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public static void PLayerPrompt()
        {

        }

        public static void CubeEmpty()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
        public static void CubePlayerWin()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
        public static void CubeEnemyWin()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("|                                             ||                                              |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }
}
