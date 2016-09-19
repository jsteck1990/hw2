using System;
using System.Collections.Generic;
using System.Linq;

namespace hw2
{
	public class Rank
	{
		public static Rank TWO = new Rank {RankName = "Two", RankSymbol = "2", RankNum = 2};
		public static Rank THREE = new Rank {RankName = "Three", RankSymbol = "3", RankNum = 3};
		public static Rank FOUR = new Rank {RankName = "Four", RankSymbol = "4", RankNum = 4};
		public static Rank FIVE = new Rank {RankName = "Five", RankSymbol = "5", RankNum = 5};
		public static Rank SIX = new Rank {RankName = "Six", RankSymbol = "6", RankNum = 6};
		public static Rank SEVEN = new Rank {RankName = "Seven", RankSymbol = "7", RankNum = 7};
		public static Rank EIGHT = new Rank {RankName = "Eight", RankSymbol = "8", RankNum = 8};
		public static Rank NINE = new Rank {RankName = "Nine", RankSymbol = "9", RankNum = 9};
		public static Rank TEN = new Rank {RankName = "Ten", RankSymbol = "10", RankNum = 10};
		public static Rank JACK = new Rank {RankName = "Jack", RankSymbol = "J", RankNum = 11};
		public static Rank QUEEN = new Rank {RankName = "Queen", RankSymbol = "Q", RankNum = 12};
		public static Rank KING = new Rank {RankName = "King", RankSymbol = "K", RankNum = 13};
		public static Rank ACE = new Rank {RankName = "Ace", RankSymbol = "A", RankNum = 14};

		private string RankName { get; set; }
		private string RankSymbol { get; set; }
		public  int RankNum { get; set; }// for comparison

		public static List<Rank> VALUES = new List<Rank>()
		{TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE};

		public Rank(){
		}
	
		public int CompareTo(Rank OtherRankObj){
			Rank RankObj = (Rank)OtherRankObj;

			if (this.RankNum > RankObj.RankNum)
				return 1;
			else if (this.RankNum < RankObj.RankNum)
				return -1;
			else
				return 0;
		}

		public string GetSymbol(){
			return RankSymbol;
		}


		public string GetName(){
			return RankName;
		}

		override public string ToString(){
			return RankName;
		}
			
	}
}

