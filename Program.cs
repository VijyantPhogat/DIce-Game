namespace Dice_Game
{
    class program{
        static void Main(string[] args){

            var playerscore=0;
            var enemyscore=0;

            Random random= new Random();

            for(int i = 0; i < 10; i++){ 
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to roll the dice : ");
                Console.ReadKey();
                var playerRandomNum = random.Next(1, 7);
                Console.WriteLine($"You rolled a {playerRandomNum}");

                Console.WriteLine("...");
                Thread.Sleep(1000);

                var enemyRandomNum = random.Next(1,7);
                Console.WriteLine($"Enemy rolled a {enemyRandomNum}");

            if(playerRandomNum > enemyRandomNum){
                playerscore++;
                Console.WriteLine(" ");
                Console.WriteLine("Player won this round !");
                Console.WriteLine("++++++++++++++++++++++++");
                Console.WriteLine(" ");
            }
            else if(enemyRandomNum > playerRandomNum){
                enemyscore++;
                Console.WriteLine(" ");
                Console.WriteLine("Enemy won this round !");
                Console.WriteLine("++++++++++++++++++++++++");
                Console.WriteLine(" ");
            }
            else{
                Console.WriteLine(" ");
                Console.WriteLine(" Round is draw !!! ");
                Console.WriteLine("++++++++++++++++++++++++");
                Console.WriteLine(" ");
            }
            }
            if(playerscore > enemyscore){
                Console.WriteLine("-------------------------------");
                Console.WriteLine("CONGRATULATIONS, YOU WON !!!!");
                Console.WriteLine("-------------------------------");
            }
            else if(enemyscore>playerscore){
                Console.WriteLine("-------------");
                Console.WriteLine("You lost.");
                Console.WriteLine("-------------");
            }
            else {
                Console.WriteLine("-------------");
                Console.WriteLine("IT'S A DRAW!");
                Console.WriteLine("-------------");
            }
        }
    }
}