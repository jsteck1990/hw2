﻿using System;

namespace hw2
{
	public class CardCountGame
	{
		public CardCountGame ()
		{
		}

		public static void PlayGame(){
			CardCountHand CCHand1 = new CardCountHand();
			CardCountHand CCHand2 = new CardCountHand ();

			Deck CCDeck = new Deck ();;

			foreach (Suit s in Suit.VALUES)
				foreach (Rank r in Rank.VALUES)
					CCDeck.AddCard (new Card (s, r));

				CCHand1.AddCard (CCDeck.DealOne ());
				CCHand1.AddCard (CCDeck.DealOne ());
				CCHand1.AddCard (CCDeck.DealOne ());
				CCHand1.AddCard (CCDeck.DealOne ());
				CCHand1.AddCard (CCDeck.DealOne ());
				CCHand1.AddCard (CCDeck.DealOne ());
				CCHand1.AddCard (CCDeck.DealOne ());
				CCHand1.AddCard (CCDeck.DealOne ());

				CCHand2.AddCard (CCDeck.DealOne ());
				CCHand2.AddCard (CCDeck.DealOne ());
				CCHand2.AddCard (CCDeck.DealOne ());
				CCHand2.AddCard (CCDeck.DealOne ());
				CCHand2.AddCard (CCDeck.DealOne ());
				CCHand2.AddCard (CCDeck.DealOne ());
				CCHand2.AddCard (CCDeck.DealOne ());
				CCHand2.AddCard (CCDeck.DealOne ());


				Console.WriteLine ("Hand 1: {0} | Value: {1}\n", CCHand1, CCHand1.EvaluateHand());
				Console.WriteLine ("Hand 2: {0} | Value: {1}\n", CCHand2, CCHand2.EvaluateHand());

			Console.WriteLine ("Cards Remaining: {0}", CCDeck.GetCardsRemaining ());

		}
	}
}

