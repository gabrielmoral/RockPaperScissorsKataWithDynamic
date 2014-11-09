using System;

namespace RockPaperScissorsKata
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

		private string Hand (Rock gesture1, Paper gesture2)
		{

		}

		private string Hand (Paper gesture1, Scissors gesture2)
		{

		}

		private string Hand (Scissors gesture1, Rock gesture2)
		{

		}

	}
}

