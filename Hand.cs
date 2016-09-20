using System;
using System.Collections.Generic;
using System.Linq;

namespace hw2
{
	public abstract class Hand
	{
		private List<Card> PlayerHand;
		public Hand ()
		{
			PlayerHand = new List<Card> ();
		}

		public void AddCard(Card c){
		}

		abstract public int CompareTo (Hand OtherHandObj);

		public bool ContainsCard(Card c){
			if (PlayerHand.Contains(c))
				return true;
			else
				return false;
		}

		public void DiscardHand(){
			this.PlayerHand.Clear ();
		}

		public int FindCard(Card c){
			return PlayerHand.IndexOf (c);
		}

		public Card GetCardAtIndex(int i){
			return PlayerHand[i];
		}

		public int GetNumberOfCards(){
			return PlayerHand.Count;
		}

		private bool IsEmpty(){
			if (PlayerHand.Count == 0)
				return true;
			else
				return false;
		}

		public Card RemoveCard(Card c){
			Card CardRemoved = new Card ();

			if(IsEmpty() == false && ContainsCard(c) == true)
			CardRemoved = c;
			this.PlayerHand.Remove(c);
			return CardRemoved;
		}

		public Card RemoveCard(int i){
			Card CardRemoved = new Card ();

			if(IsEmpty() == false)
				CardRemoved = PlayerHand[i];
			if(ContainsCard(CardRemoved) == true)
				this.PlayerHand.RemoveAt (i);
				return CardRemoved;

		}

		abstract public int EvaluateHand ();

		override public string ToString(){
			foreach(Card c in PlayerHand)
				return String.Format("{0,4}", c);
			return "";
		}
	}
}

