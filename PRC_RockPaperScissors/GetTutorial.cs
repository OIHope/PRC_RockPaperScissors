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
            Console.Clear();
            TutorialSequence();
            GetMenu.Menu();
        }
        public static void TutorialSequence()
        {
            GetInterface.AlwaysOnScreenMenu();
            Console.WriteLine("\n   At the top you can see you stats\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
            
            GetInterface.AlwaysOnScreen();
            Console.WriteLine("\n   Then you have battle statistics, like enemy name, how much wins and so on\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();

            GetInterface.AlwaysOnScreen();
            GetInterface.CubeEmpty();
            Console.WriteLine("\n   These are battle cubes. You will see you and enemies weapons, and who wins of loses\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeEmpty();
            Console.WriteLine("\n   The rules are simple: rock beets scissors, scissors beet paper and paper beets rock\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeEmpty();
            Console.WriteLine("\n   Battle lasts for 3 rounds or untill two wins. Draws dont count so round ends with smb win or lose\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();

            GetInterface.AlwaysOnScreen();
            GetInterface.CubeEmpty();
            Console.WriteLine("\n   A tip for you - your oponents are the worst pocker players, just so you know.\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
            GetInterface.AlwaysOnScreen();
            GetInterface.CubeEmpty();
            Console.WriteLine("\n   Good luck!\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
