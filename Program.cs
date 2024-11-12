using System;

namespace Dice_Game
{
    class program{
        static void Main(string[] args){
            
            int playerRandomNum;
            int enemyRandomNum;

            int playerscore=0;
            int enemyscore=0;

            Random random= new Random();

            for(int i = 0; i < 10; i++){
             System.Console.WriteLine(" ");
            System.Console.WriteLine("Press any key to roll the dice : ");
            Console.ReadKey();
            playerRandomNum = random.Next(1, 7);
            System.Console.WriteLine($"You rolled a {playerRandomNum}");

            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);

            enemyRandomNum = random.Next(1,7);
            System.Console.WriteLine($"Enemy rolled a {enemyRandomNum}");

            if(playerRandomNum > enemyRandomNum){
                playerscore++;
            System.Console.WriteLine(" ");
                System.Console.WriteLine("Player won this round !");
            System.Console.WriteLine("++++++++++++++++++++++++");
            System.Console.WriteLine(" ");
            }
            else if(enemyRandomNum > playerRandomNum){
                enemyscore++;
            System.Console.WriteLine(" ");
                System.Console.WriteLine("Enemy won this round !");
            System.Console.WriteLine("++++++++++++++++++++++++");
            System.Console.WriteLine(" ");
            }
            else{
            System.Console.WriteLine(" ");
                System.Console.WriteLine(" Round is draw !!! ");
            System.Console.WriteLine("++++++++++++++++++++++++");
            System.Console.WriteLine(" ");
            }
            }
            if(playerscore > enemyscore){
                System.Console.WriteLine("-------------------------------");
                System.Console.WriteLine("CONGRATULATIONS, YOU WON !!!!");
                System.Console.WriteLine("-------------------------------");
            }
            else if(enemyscore>playerscore){
                System.Console.WriteLine("-------------");
                System.Console.WriteLine("You lost.");
                System.Console.WriteLine("-------------");
            }
            else {
                System.Console.WriteLine("-------------");
                System.Console.WriteLine("IT'S A DRAW!");
                System.Console.WriteLine("-------------");
            }
        }
    }
}