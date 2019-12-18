using System;
using Game.Models;

namespace Game
{
    public class RPSGame
    {
        public static void Main()
        {
          Console.WriteLine("Player 1, please choose:\n 1 Rock \n 2 Paper \n 3 Scissors");
          int input = int.Parse(Console.ReadLine());
          Player player1 = null;
          Player player2 = null;
          int check = 1;
          while(check == 1)
          {
            if(input == 1)
            {
              player1 = new Player("rock");
            }
            else if(input == 2)
            {
              player1 = new Player("paper");
            }
            else if(input == 3)
            {
              player1 = new Player("scissors");
            }
            check++;
          }
          Console.WriteLine("Player 2, please choose:\n 1 Rock \n 2 Paper \n 3 Scissors");
          input = int.Parse(Console.ReadLine());
          while(check == 2)
          {
            if(input == 1)
            {
              player2 = new Player("rock");
            }
            else if(input == 2)
            {
              player2 = new Player("paper");
            }
            else if(input == 3)
            {
              player2 = new Player("scissors");
            }
            check++;
          }

          Console.WriteLine(Player.Winner(player1,player2));

        }
    }
}
