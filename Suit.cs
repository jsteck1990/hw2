using System;
using System.Collections.Generic;

namespace hw2
{
	public class Suit
	{
		public static Suit CLUBS = new Suit {SuitName = "Clubs", SuitSymbol = "\u2663", SuitNum = 1};
		public static Suit DIAMONDS = new Suit {SuitName = "Diamonds", SuitSymbol = "\u2666", SuitNum = 2};
		public static Suit HEARTS = new Suit {SuitName = "Hearts", SuitSymbol = "\u2665", SuitNum = 3};
		public static Suit SPADES = new Suit {SuitName = "Spades", SuitSymbol = "\u2660", SuitNum = 4};

		private string SuitSymbol { get; set;}
		private string SuitName { get; set;}
		public int SuitNum { get; set; }//for comparison

		public static List<Suit> VALUES = new List<Suit>(){CLUBS, DIAMONDS, HEARTS, SPADES};

		public Suit ()
		{
		}
			

		public int CompareTo(Suit OtherSuitObj){
			Suit SuitObj = (Suit)OtherSuitObj;

			if (this.SuitNum > SuitObj.SuitNum)
				return 1;
			else if (this.SuitNum < SuitObj.SuitNum)
				return -1;
			else
				return 0;
		}

		public string GetSymbol(){
			return SuitSymbol;
		}

		public string GetName(){
			return SuitName;
		}

		override public string ToString(){
			return SuitName;
		}
	}
}

