using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    internal class GetMenu
    {
        //тут буде меню, де будуть переходи до різних частин гри
        //порядок\схема така:
        //
        //Почати гру
        //Переглянути туторіал + якусь позначку, якшо вже переглядали
        //Налаштування
        //---Змінити імя
        //---Змінити вік
        //---повернутись назад
        //Вихід
        //
        // при зміні віку <12 в налаштуваннях виводимо повідомлення що нізя і просимо ввести ще раз, доки не введуть нормальне значення
        // для приколу можна навіть додати кількість спроб
        public static void Menu()
        {

        }
        public static void Settings()
        {

        }
        public static void ChangeName()
        {

        }
        public static void ChangeAge()
        {

        }
        public static void Exit()
        {
            //тут треба зробити щоб вилізло "вив впевнені?", а потім очистило консоль і по центру написало що ми будемо сумувати
        }
    }
}
