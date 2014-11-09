using System;

namespace RockPaperScissorsKataWithDynamic
{
	public class Game
	{
		public const string Rock = "Rock";
		public const string  Paper = "Paper";
		public const string  Scissors = "Scissors";
		public const string  Tie = "Tie";

		public string Hand (Gesture gesture1, Gesture gesture2)
		{
			return this.Hand (gesture1 as dynamic, gesture2 as dynamic); 
		}

		private string Hand (Rock rock1, Rock rock2)
		{
			return Game.Tie;
		}

		private string Hand (Paper paper1, Paper paper2)
		{
			return Game.Tie;
		}

		private string Hand (Scissors scissors1, Scissors scissors2)
		{
			return Game.Tie;
		}

		private string Hand (Rock rock, Paper paper)
		{
			return Game.Paper;
		}

		private string Hand ( Paper paper, Rock rock)
		{
			return Game.Paper;
		}

		private string Hand (Paper paper, Scissors scissors)
		{
			return Game.Scissors;
		}

		private string Hand ( Scissors scissors,Paper paper)
		{
			return Game.Scissors;
		}

		private string Hand (Scissors scissors, Rock rock)
		{
			return Game.Rock;
		}

		private string Hand (Rock rock, Scissors scissors)
		{
			return Game.Rock;
		}
	}
}

