using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFirst
{
	public class Food
	{
		public string Name { get; }

		public double Price { get; set; }

		public Food(string name, double price)
		{
			this.Name = name;
			this.Price = price;
		}
	}
}
