using System;
using System.Collections.Generic;
using System.Linq;

namespace hw2
{
	public class Deck
	{
		public List<Card> CardDeck;
		private List<Card> CardsDealt = new List<Card>();

		private int DeckCount = 0;

		public Deck ()
		{
			CardDeck = new List<Card> ();
		}

		public void AddCard(Card c){
			CardDeck.Add (c);
		}

		public Card DealOne(){
			Card CardDealt = new Card();
			if(IsEmpty() == false)
				CardDealt = CardDeck.First ();
			CardDeck.Remove (CardDealt);
			CardsDealt.Add (CardDealt);
			return CardDealt;
		}

		public int GetCardsRemaining(){
			return CardDeck.Count;
		}

		public int GetDeckSize(){
			DeckCount = CardDeck.Count;
			return CardDeck.Count;
		}

		public bool IsEmpty(){
			if (GetDeckSize () == 0)
				return true;
			else
				return false;
		}

		public void Shuffle(){
			var rnd = new Random();
			CardDeck = CardDeck.OrderBy (x => rnd.Next ()).ToList ();
		}

		public void RestoreDeck(){
			foreach (Card c in CardsDealt)
				CardDeck.Add (c);
			CardsDealt.Clear();
		}
	}
}

