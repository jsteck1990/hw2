using System;
using System.Collections.Generic;
using System.Linq;

namespace hw2
{
	public class CardCountHand : Hand
	{
		private static int HandValue = 0;
		private List<int> RankValues = new List<int>();

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

			foreach (Card c in PlayerHand) {
				RankValues.Add (c.getRank ().RankNum);
				
//				switch (RankValue) {
//				case "A":
//					RankValue = "A";
//					HandValue += 1;
//					break;
//				case "2":
//					RankValue = "2";
//					HandValue += 2;
//					break;
//				case "3":
//					RankValue = "3";
//					HandValue += 3;
//					break;
//				case "4":
//					RankValue = "4";
//					HandValue += 4;
//					break;
//				case "5":
//					RankValue = "5";
//					HandValue += 5;
//					break;
//				case "6":
//					RankValue = "6";
//					HandValue += 6;
//					break;
//				case "7":
//					RankValue = "7";
//					HandValue += 7;
//					break;
//				case "8":
//					RankValue = "8";
//					HandValue += 8;
//					break;
//				case "9":
//					RankValue = "9";
//					HandValue += 9;
//					break;
//				case "10":
//					RankValue = "10";
//					HandValue += 10;
//					break;
//				case "J":
//					RankValue = "J";
//					HandValue += 10;
//					break;
//				case "Q":
//					RankValue = "Q";
//					HandValue += 10;
//					break;
//				case "K":
//					RankValue = "K";
//					HandValue += 10;
//					break;
//				default:
//					HandValue = 0;
//					break;
//				}
			}
			
			return HandValue;
		}

	}
}

