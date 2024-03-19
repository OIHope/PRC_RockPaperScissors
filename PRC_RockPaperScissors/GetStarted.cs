using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    class GetStarted
    {
        public static void Start()
        {
            GetInterface.ScreenSize();
            Console.Clear();
            GetInterface.WelcomeTitle1();
            Console.Clear();
            GetInterface.WelcomeTitle2();
            Console.Clear();
            AskName();
            Console.Clear();
            AskAge();
            Console.Clear();
            AskTutorial();
            Console.Clear();
            GetMenu.Menu();
        }
        public static void AskName()
        {
            bool inSet = true;
            while (inSet)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.StartAskName();

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
                }
            }
        }
        public static void AskAge()
        {
            bool inSet = true;
            while (inSet)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.StartAskAge();

                bool onlyNum = int.TryParse(Console.ReadLine(), out int age);

                if ((onlyNum) && (age > 100))
                {
                    Console.WriteLine("\n   Well, if you play this you may be a dino, realy... but no, try again\n\n===Press Enter===");
                    Console.ReadKey();
                }
                else if ((onlyNum) && (age < 12))
                {
                    Console.Clear();
                    GetInterface.AlwaysOnScreenMenu();
                    GetInterface.StartAgeWrong();
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if ((onlyNum))
                {
                    _Master.gameValue.plAge = age;
                    inSet = false;
                }
            }

        }
        public static void AskTutorial()
        {
            bool inSet = true;
            while (inSet)
            {
                Console.Clear();
                GetInterface.AlwaysOnScreenMenu();
                GetInterface.StartTutorial();

                string tempName = Console.ReadLine();

                if (tempName == "1")
                {
                    GetTutorial.StartTutorial();
                    inSet = false;
                }
                else if (tempName == "2")
                    inSet = false;
            }

        }
    }
}
