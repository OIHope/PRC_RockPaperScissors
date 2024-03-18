using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    class GetStarted
    {
        //тут ми починаємо з заставки гри, хто розробив, хз шось таке, намальоване згори титулка з назвою гри, та обовязкове 12+
        //також як ІДЕЯ можна відмалювати приблизні розміри консолі і запропонувати гравцю свою консоль підігнати під ці параметри
        //перед кожним відмалювання треба робити щось типу ----press Enter---- і відділяти лог якоюсь рискою
        //далі ми починаємо знайомство, аля система запрошує імя користувача та вік
        // якшо вік менше 12 то оновлюємо вікно з великою титулкою типу SYSTEM ERROR, попереджаємо шо грати нізя і все, допобачення
        // після того як все ввели, пропонуємо ознайомитись з туторіалом
        // якшо так, то виводимо по черзі елементи інтерфейсу, та підписуємо їх логом, для цього мабуть зробити окремий файл!
        // після переходимо до меню, де ми зможемо змінити імя, вік, подивитись туторіал, почати битву, закрити додаток (порядок зовсім інший буде)
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
                    _Master.playerStat.plName = tempName;
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
                    _Master.playerStat.plAge = age;
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
                else
                {
                    _Master.playerStat.plName = tempName;
                    inSet = false;
                }
            }

        }
    }
}
