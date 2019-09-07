using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFirst
{
	public class ShoppingCartSimple
	{
		public double Sum { get; set; }

		public ShoppingCartSimple()
		{
			Sum = 0;
		}

		public void AddToCart(Food food, int amount)
		{
			Sum = Sum + amount * food.Price;
		}
	}
}
