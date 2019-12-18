using System;

namespace Game.Models
{
  public class Player
  {
    private string rps;

    public Player(string givenRPS)
    {
      this.rps = givenRPS;
    }

    public string GetRPS()
    {
      return this.rps;
    }

    public void SetRPS(string new_RPS)
    {
      this.rps = new_RPS;
    }

    public static string Winner(Player player1, Player player2)
    {
      if ((player1.GetRPS() == "rock" || player2.GetRPS() == "rock") && (player1.GetRPS() == "scissors" || player2.GetRPS() == "scissors"))
      {
        return "rock wins";
      }
      else if ((player1.GetRPS() == "rock" || player2.GetRPS() == "rock") && (player1.GetRPS() == "paper" || player2.GetRPS() == "paper"))
      {
        return "paper wins";
      }
      else if ((player1.GetRPS() == "paper" || player2.GetRPS() == "paper") && (player1.GetRPS() == "scissors" || player2.GetRPS() == "scissors"))
      {
        return "scissors wins";
      }
      return "draw";
    }

    public string PrintRPS()
    {
      return "Player's choice: " + this.rps;
    }

  }
}
