using System;

namespace hw2
{
	public class Card
	{
		public static readonly Card card = new Card{suit = "", rank = "", CardValue = 0};

		private Rank CardRank;
		private Suit CardSuit;

		private string rank;
		private string suit;
		public int CardValue;//for comparison

		public Card(){
			
		}

		public Card (Suit s, Rank r)
		{
			CardRank = r;
			CardSuit = s;

			suit = s.GetSymbol();
			rank = r.GetSymbol();

			CardValue = r.RankNum + s.SuitNum;
		}

		public int CompareTo(Card OtherCardObj){
			Card Cardobj = (Card)OtherCardObj;

			if (this.CardValue < Cardobj.CardValue)
				return -1;
			else if (this.CardValue > Cardobj.CardValue)
				return 1;
			else
			return 0;
		}

		public Rank getRank(){
			return CardRank;
		}

		public Suit getSuit(){
			return CardSuit;
		}

		override public string ToString(){
			return rank + suit;
		}
	
	}
}

