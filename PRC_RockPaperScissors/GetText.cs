using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC_RockPaperScissors
{
    
    public class GetText
    {
        public static void EnemyName()
        {
            Random random = new Random();
            string[] name = {"AndyWendy", "bartolomy33", "candyWeaver", "DandyCroco", "+ethanCarther+", "ferreroFartshen",
                "gman", "heSUS", "iceBox", "jeSUS", "kontra","LEON1DAS","maydaymayday","nigiri","onlyRocks","pappa","quakeIsmyReligion",
                "ROCK LEE","SUSuke","yeeeet","zelebobik","uolsdfljbnsd","vartoschool","vioria","twitch.com","nonameuser"};
            int i = random.Next(name.Length-1);
            _Master.gameValue.enemyName = name[i];
        }
        public static void EnemyWeaponResponce(string enemyWeaponID)
        {
            Random rand = new Random();
            string i = enemyWeaponID;
            int j = rand.Next(0,10); 

            string[] rock = new string[]
            {
                "Your opponent is ready, seemingly as solid as a mountain, yet calm as its shadowed valleys.",
                "It seems your adversary is as unyielding as a cliff face, yet serene like the quiet of its caves.",
                "Your rival stands firm, displaying a calm as steady as the rolling hills.",
                "The opponent remains resolute, a calm as enduring as the ancient rocks.",
                "Your challenger appears as immovable as a monolith, yet tranquil as a mountain lake.",
                "Seemingly unshaken, your opponent exudes a calm akin to the silence of mountain peaks.",
                "Your adversary is as steadfast as the granite beneath our feet, yet calm like a secluded hilltop.",
                "It appears your rival is as firm as a rock formation, yet peaceful as a mountain meadow.",
                "The opponent displays a resolute calm, reminiscent of the strength of a rugged cliffside.",
                "Your challenger maintains a serene poise, like the unyielding majesty of ancient mountains." 
            };
            string[] scissors = new string[]
            {
                "Your opponent is ready, as sharp as a dagger, yet calm like the eye of a storm.",
                "It seems your adversary is as keen as a razor's edge, yet composed like a surgeon.",
                "Your rival stands firm, displaying a sharpness akin to a wolf's teeth, yet tranquil as a clear blade.",
                "The opponent remains as piercing as a needle, yet serene like the stillness of a scalpel.",
                "Your challenger appears as cutting as scissors, yet poised like a well-honed blade.",
                "Seemingly unyielding, your opponent exudes a sharpness reminiscent of a sword's edge, yet calm as a master swordsman.",
                "Your adversary is as incisive as a surgeon's tool, yet cool like the steel of a dagger.",
                "It appears your rival is as sharp as a thorn, yet peaceful like the gleam of a finely honed knife.",
                "The opponent displays a cutting resolve, akin to the bite of a sharpened axe, yet composed like a skilled fencer.",
                "Your challenger maintains a razor-sharp focus, like the precision of a surgeon's scalpel."
            };
            string[] paper = new string[]
            {
                "Your opponent is ready, as easy to read as an open book, yet calm like a peaceful page.",
                "It seems your adversary is as transparent as a sheet of paper, yet composed like a well-written novel.",
                "Your rival stands firm, displaying a clarity akin to a well-printed page, yet tranquil as a gentle breeze through a bookshelf.",
                "The opponent remains as straightforward as a manual, yet serene like the quiet of a library.",
                "Your challenger appears as readable as a well-organized essay, yet poised like a well-turned phrase.",
                "Seemingly effortless, your opponent exudes a simplicity reminiscent of a children's storybook, yet calm as a bedtime tale.",
                "Your adversary is as clear as a textbook's explanation, yet cool like the margins of a journal.",
                "It appears your rival is as easy to understand as a recipe, yet peaceful like the blank pages of a notebook.",
                "The opponent displays a readable resolve, akin to the logic of a mathematical proof, yet composed like a classic novel.",
                "Your challenger maintains a flow that is as smooth as a well-edited manuscript, like the ease of a reader through its pages."
            };

            if (i == "rock")
                _Master.gameValue.enemyResponce = rock[j];
            else if (i == "paper")
                _Master.gameValue.enemyResponce = paper[j];
            else if(i == "scissors")
                _Master.gameValue.enemyResponce = scissors[j];
        }
        public static void Responce(string roundEnd)
        {
            Random rand = new Random();
            string i = roundEnd;
            int j = rand.Next(0, 10);


            string[] responceLose = new string[]
            {
                "It's just a game, my friend. There's always another chance.",
                "Don't worry, we all have our off days. You'll bounce back stronger.",
                "Sometimes the best lessons come from defeat. You'll come back even better next time.",
                "Losing today only means you're one step closer to winning tomorrow.",
                "You gave it your all, and that's what matters most. Keep your chin up.",
                "Remember, even the greatest champions have faced setbacks. You're in good company.",
                "It's okay to feel disappointed, but don't let it discourage you. You're capable of amazing things.",
                "In the grand scheme of things, this is just a moment. Your journey is far from over.",
                "Take a breath, shake it off, and get ready for the next challenge. You've got this.",
                "Just think of this as a plot twist in your story of success. The best is yet to come."
            };
            string[] responceWin = new string[]
            {
                "Congratulations on the win! That was a well-deserved victory.",
                "Well done! Your skill truly shined through in this match.",
                "Impressive performance! You really dominated the game.",
                "Great job on the win! Your strategy was flawless.",
                "You played phenomenally! It was an honor to compete against you.",
                "Outstanding victory! You've proven yourself a formidable opponent.",
                "Bravo! Your precision and skill were unmatched in this match.",
                "A masterful display of skill! It's always a pleasure to face a player of your caliber.",
                "Superb gameplay! You've certainly earned this win.",
                "Well played! I'd love to see a rematch sometime."
            };
            string[] responceDraw = new string[]
            {
                "A draw! What an intense match. How about we settle this in another round?",
                "Well, looks like we're evenly matched! Shall we play another to break the tie?",
                "A stalemate! This calls for a rematch, don't you think?",
                "A draw it is! We're both skilled players. Another game to determine the victor?",
                "Interesting result! How about we play one more to see who comes out on top?",
                "A tie! It seems fate wants us to continue this battle. Ready for another round?",
                "No clear winner this time! How about a friendly rematch to settle things?",
                "A draw? It seems we're evenly matched. Want to go for another round?",
                "Well played! Looks like we need another match to decide the winner.",
                "A deadlock! This calls for a rematch. Are you up for it?"
                };
            string[] responceStart = new string[]
            {
                "Hello there! Ready for a friendly match?",
                "Hey! Hope you're up for a fun game!",
                "Hi! Excited to play against you!",
                "Greetings! Shall we test our skills?",
                "Hello! Looking forward to a great game!",
                "Hey there! Ready to show off your strategy?",
                "Hi! Let's dive into a match, shall we?",
                "Hello! Hope you're ready for some competition!",
                "Hey! How about a game to kick things off?",
                "Hi there! Let's have a friendly match!"
            };
            if (i == "win")
                _Master.gameValue.enemyResponce = responceWin[j];
            else if (i == "lose")
                _Master.gameValue.enemyResponce = responceLose[j];
            else if (i == "draw")
                _Master.gameValue.enemyResponce = responceDraw[j];
            else if (i == "start")
                _Master.gameValue.enemyResponce = responceStart[j];
        }
    }
}
