using System;

namespace ConsoleFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			/// Variables
			// Value type variables
			int x = 5;
			int y = 25;

			Console.WriteLine(x + y);
			Console.WriteLine("5" + "25");

			char letter = 'a';
			char anotherLetter = 'b';

			Console.WriteLine(letter + anotherLetter); // 195 ??? Ascii tabel 97 + 98

			bool isStudying = true;
			bool isWorking = false;

			//Console.WriteLine(isStudying + isWorking); don't compile

			Console.WriteLine(isStudying && isWorking);
			Console.WriteLine(isStudying || isWorking) ;

			//Reference type

			string firstName = "Olga";
			string lastName = "Trikk";

			Console.WriteLine(firstName + lastName);

			// if else
			if (x > 0)
				Console.WriteLine("positive");
			else if (x < 0)
				Console.WriteLine("negative");
			else
				Console.WriteLine("zero");

			// methods - see below
			// - isPositive 
			Console.WriteLine(IsPositive(-10));

			//arrays
			int[] numbers = { 1, -7, 24, 0 };
			// loops - tsüklid
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}
			// loops with methods
			foreach (int number in numbers)
			{
				Console.WriteLine(IsPositive(number));
			}
			foreach (int number in numbers)
			{
				Console.WriteLine(number + " is " + GetSign(number));
			}

			Console.WriteLine("For cycle");
			for (int i = 0;  i < 10; i+=2)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("While cycle");
			int j = 0;
			while (j < 10) {
				Console.WriteLine(j);
				j+=2;
			}


			/// OOP - classes & objects
			Food noodles = new Food("Noodles", 1.5);
			Console.WriteLine(noodles.Name);
			Console.WriteLine(noodles.Price);

			//noodles.Name = "banana"; no setter => doesn't compile
			noodles.Price = 2;  // there's setter

			Food banana = new Food("Banana", 1);
			Food milk = new Food("Milk", 1.2);

			// arrays 
			Food[] grocery = { noodles, banana, milk };
			Console.WriteLine(grocery[1].Name);  
			// Console.WriteLine(grocery[3].Name); // IndexOutOfRangeException

			ShoppingCartSimple myCart = new ShoppingCartSimple();
			myCart.AddToCart(noodles, 2);
			myCart.AddToCart(banana, 5);
			myCart.AddToCart(milk, 1);

			Console.WriteLine(myCart.Sum);

			ShoppingCartDetailed myDetailedCart = new ShoppingCartDetailed();
			myDetailedCart.AddToCart(noodles, 2);
			myDetailedCart.AddToCart(banana, 5);
			myDetailedCart.AddToCart(milk, 1);
			Console.WriteLine(myDetailedCart.CalculateSum());
		}

		static bool IsPositive(int x)
		{
			if (x > 0)
				return true;
			else
				return false;
		}

		static string GetSign(int x)
		{
			if (x > 0)
				return "positive";
			else if (x < 0)
				return "negative";
			else
				return "zero";
		}
		
	}
}
