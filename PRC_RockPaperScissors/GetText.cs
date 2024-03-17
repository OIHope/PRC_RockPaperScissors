using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    
    public class GetText
    {
        
        //поки що як задумка, але тут зберігати та проводити текстові методи відповідей противника на різні ситуації
        // також можна тут зберігати майже всі текстові штуки і витягувати їх звідси, або створити копію в потрібний клас і все
        // так як тут не має бути НІЯКИХ значень, хіба що ті що йдуть з _Master.playerStat
        public static void ResponceWin()
        {

        }
        public static void ResponceLose()
        {

        }
        public static void EnemyName()
        {
            // тут буде список імен, ми його передаватимемо в МАСТЕР після натиску на кнопку старт, або зіграти ще раз
            // зробив але треба ТЕСТ!
            //
            //ЗАТЕСТИТИ!
            //
            //
            Random random = new Random();
            string[] name = {"AndyWendy", "bartolomy33", "candyWeaver", "DandyCroco", "+ethanCarther+", "ferreroFartshen",
                "gman", "heSUS", "iceBox", "jeSUS", "kontra","LEON1DAS","maydaymayday","nigiri","onlyRocks","pappa","quakeIsmyReligion",
                "ROCK LEE","SUSuke","yeeeet","zelebobik","uolsdfljbnsd","www.rockpaperscissors.varto.com","vioria","twitch.com","nonameuser"};
            int i = random.Next(name.Length-1);
            _Master.playerStat.enemyName = name[i];
        }
    }
}
