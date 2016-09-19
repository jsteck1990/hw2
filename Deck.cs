using System;
using System.Collections.Generic;
using System.Linq;

namespace hw2
{
	public class Deck
	{
		public List<Card> CardDeck;
		public Deck ()
		{
			CardDeck = new List<Card> (){ };
		}

		public void AddCard(Card c){
			CardDeck.Add (c);
		}

		public Card DealOne(){
			Card CardDealt = new Card();
			if(IsEmpty() == true)
				CardDealt = CardDeck.First ();
			CardDeck.Remove (CardDealt);
			return CardDealt;
		}

		public int GetCardsRemaining(){
			return CardDeck.Count;
		}

		public int GetDeckSize(){
			return CardDeck.Count;
		}

		public bool IsEmpty(){
			if (GetDeckSize () == 0)
				return true;
			else
				return false;
		}

		void Shuffle(){
		}
	}
}

