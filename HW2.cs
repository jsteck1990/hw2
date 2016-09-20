using System;
using System.Collections.Generic;

namespace hw2
{

	class MainClass
	{
		public static void Main (string[] args)
		{
			CardCountGame CCG = new CardCountGame ();
//			Deck d1 = new Deck ();
//			Deck d2 = new Deck ();
//			
//			Card c1 = new Card (Suit.SPADES, Rank.ACE);
//			Card c2 = new Card (Suit.DIAMONDS, Rank.TWO);
////
////			Console.WriteLine (c1.getRank() + "\n");
////			Console.WriteLine (c1.getSuit () + "\n");
////			Console.WriteLine (c1 + "\n");
////
////			Console.WriteLine ("\n--------------------------------------------------------\n");
////
////			foreach(Suit s in Suit.VALUES)
////				Console.WriteLine (s.GetSymbol() + " " + s);
////
////			Console.WriteLine ();
////
////			foreach (Rank r in Rank.VALUES)
////				Console.WriteLine (r.GetSymbol() + " " + r);
////
////			Console.WriteLine ();
////
////			Console.WriteLine ("{0} compared to {0}: {1}\n", c1, c1.CompareTo(c1));
//
//			foreach (Suit s in Suit.VALUES)
//				foreach (Rank r in Rank.VALUES)
//					d1.AddCard (new Card (s, r));
//
//			d1.Shuffle ();
//
//
//
////			Console.WriteLine (d1.GetDeckSize() + "\n");
////
////			Console.WriteLine(d1.DealOne () + "\n");
////			Console.WriteLine(d1.DealOne () + "\n");
////			Console.WriteLine(d1.DealOne () + "\n");
////			Console.WriteLine(d1.DealOne () + "\n");
////			Console.WriteLine(d1.DealOne () + "\n");
////
////			Console.WriteLine (d1.GetCardsRemaining ());
////
////			Console.WriteLine ("Press Enter to restore deck..");
////			Console.ReadKey ();
////
////			d1.RestoreDeck ();
////
////			Console.WriteLine ("\n" + d1.GetDeckSize() + "\n");
//
//			for(int i=0; i < 8; i++)
//				foreach (Suit s in Suit.VALUES)
//					foreach (Rank r in Rank.VALUES)
//						d2.AddCard (new Card (s, r));
//			for(int i=0; i < 10; i++)
//				Console.WriteLine(d2.DealOne ());

			CCG.PlayGame();
		}
	}
}
