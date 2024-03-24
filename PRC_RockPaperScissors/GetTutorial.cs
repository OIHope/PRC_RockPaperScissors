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
            
            GetInterface.AlwaysOnScreenTutorial();
            Console.WriteLine("\n   Then you have battle statistics, like AI name, how much wins and so on\n" +
                "And just so you know... this AI has many names, but don't get yourself fooled - it's NOT a human being!\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();

            GetInterface.AlwaysOnScreenTutorial();
            GetInterface.CubeEmpty();
            Console.WriteLine("\n   These are battle cubes. You will see your and AI`s weapons, and who wins of loses\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
            GetInterface.AlwaysOnScreenTutorial();
            GetInterface.CubeStart();
            Console.WriteLine("\n   The rules are simple: rock beets scissors, scissors beet paper and paper beets rock\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
            GetInterface.AlwaysOnScreenTutorial();
            GetInterface.CubeRockScissors();
            Console.WriteLine("\n   Battle lasts for 3 rounds or untill two wins. Draws DO count\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();

            GetInterface.AlwaysOnScreenTutorial();
            GetInterface.CubeDraw();
            Console.WriteLine("\n   A tip for you - your oponents are the worst pocker players, just so you know.\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
            GetInterface.AlwaysOnScreenTutorial();
            GetInterface.CubeStart();
            Console.WriteLine("\n   Good luck!\n\n===Press Enter===");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
