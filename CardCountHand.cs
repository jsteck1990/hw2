using System;
using System.Collections.Generic;
using System.Linq;

namespace hw2
{
	public class CardCountHand : Hand
	{
		int ScoreValue;

		public CardCountHand ()
		{
			
		}

		public override int CompareTo (Hand OtherHandObj)
		{
			Hand HandObj = (Hand)OtherHandObj;

			if (this.EvaluateHand () < HandObj.EvaluateHand ())
				return -1;
			if (this.EvaluateHand () > HandObj.EvaluateHand ())
				return 1;
			else
				return 0;
		}

		public override int EvaluateHand ()
		{
			string symbol = "";

			foreach (Card c in PlayerHand) {
				symbol = c.getRank ().GetSymbol ();

				switch (symbol) {
				case "A":
					ScoreValue += 1;
					break;
				case"2":
					ScoreValue += 2;
					break;
				case"3":
					ScoreValue += 3;
					break;
				case"4":
					ScoreValue += 4;
					break;
				case"5":
					ScoreValue += 5;
					break;
				case"6":
					ScoreValue += 6;
					break;
				case"7":
					ScoreValue += 7;
					break;
				case"8":
					ScoreValue += 8;
					break;
				case"9":
					ScoreValue += 9;
					break;
				case"10":
					ScoreValue += 10;
					break;
				case"J":
					ScoreValue += 10;
					break;
				case"Q": 
					ScoreValue += 10;
					break;
				case"K": 
					ScoreValue += 10;
					break;
				default:
					ScoreValue += 0;
					break;
				}
			}
			
			return ScoreValue;
		}

	}
}

