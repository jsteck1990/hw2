using System;
using System.Collections.Generic;

namespace hw2
{
	public class CardCountHand : Hand
	{
		public List<Card> PlayerHand;
		private static int HandValue;

		public CardCountHand ()
		{
			PlayerHand = new List<Card>();
			
			foreach (Card c in PlayerHand)
				foreach (Rank r in Rank.VALUES)
					if (r.RankNum == 9 || r.RankNum == 10 || r.RankNum == 11 || r.RankNum == 12)
						HandValue += 10;
					else if (r.RankNum == 1)
						HandValue += 2;
					else if (r.RankNum == 2)
						HandValue += 3;
					else if (r.RankNum == 3)
						HandValue += 4;
					else if (r.RankNum == 4)
						HandValue += 5;
					else if (r.RankNum == 5)
						HandValue += 6;
					else if (r.RankNum == 6)
						HandValue += 7;
					else if (r.RankNum == 7)
						HandValue += 8;
					else if (r.RankNum == 8)
						HandValue += 9;
					else
						HandValue = 0;
		}

		public override int CompareTo(Hand OtherHandObj){
			Hand HandObj = (Hand)OtherHandObj;

			if (this.EvaluateHand () < HandObj.EvaluateHand ())
				return -1;
			if (this.EvaluateHand () > HandObj.EvaluateHand ())
				return 1;
			else
				return 0;
		}

		public override int EvaluateHand(){
			return HandValue;
		}
	}
}

