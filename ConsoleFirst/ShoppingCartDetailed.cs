using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFirst
{
	public class ShoppingCartDetailed
	{
		public List<Food> Items { get; set; }

		public List<int> Amounts { get; set; }

		public double Sum { get; set; }

		public ShoppingCartDetailed()
		{
			Items = new List<Food>();
			Amounts = new List<int>();
		}

		public void AddToCart(Food food, int amount)
		{
			Items.Add(food);
			Amounts.Add(amount);
		}

		public double CalculateSum()
		{
			for(int i = 0; i < Items.Count; i++)
			{
				Sum = Sum + Items[i].Price * Amounts[i];
			}
			return Sum;
		}
	}
}
