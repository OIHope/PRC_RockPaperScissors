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

        }
        public static void AskAge()
        {

        }
        public static void AskTutorial()
        {

        }
    }
}
