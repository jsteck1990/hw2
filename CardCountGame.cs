using System;

namespace hw2
{
	public class CardCountGame
	{
		CardCountHand CCHand1;
		CardCountHand CCHand2;

		Deck CCDeck;

		ConsoleKeyInfo key = Console.ReadKey();

		public CardCountGame ()
		{
			CCHand1 = new CardCountHand();
			CCHand2 = new CardCountHand();

			CCDeck = new Deck();

			PlayGame ();

		}

		public void PlayGame(){
			foreach (Suit s in Suit.VALUES)
				foreach (Rank r in Rank.VALUES)
					CCDeck.AddCard (new Card (s, r));

			CCDeck.Shuffle ();

			Console.WriteLine ("WELCOME TO CARD COUNT");
			Console.WriteLine ("Press Enter to start the game..");
			key = Console.ReadKey ();
			if (key.Key == ConsoleKey.Enter) {

				DealToHands ();

				Console.WriteLine ("Keep Going? Y/N");
				key = Console.ReadKey ();
				if (key.Key == ConsoleKey.Y)
					DealToHands ();
				else if (key.Key == ConsoleKey.N)
					Console.WriteLine ("Thanks for playing!");
			}
		}

		private void DealToHands(){
			if (!CCDeck.IsEmpty ()) {
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
				CCHand2.AddCard (CCDeck.DealOne ());
			} else
				Console.WriteLine ("Deck is Empty! Cannot Deal!");
			
			Console.WriteLine ("Hand 1: {0} | Value: {1}\n", CCHand1, CCHand1.EvaluateHand());
			Console.WriteLine ("Hand 2: {0} | Value: {1}\n", CCHand2, CCHand2.EvaluateHand());

			Console.WriteLine ("Cards Remaining: {0}", CCDeck.GetCardsRemaining());
		}
	}
}

