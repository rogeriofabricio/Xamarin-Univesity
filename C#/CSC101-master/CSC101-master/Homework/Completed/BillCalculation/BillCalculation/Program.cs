using System;

namespace BillCalculation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//
			// Symbolic constants
			//
			const double SodaPrice     = 1.50;
			const double SandwichPrice = 4.50;
			const double ChipsPrice    = 1.25;
			const double TaxRate       = 0.08;
			const double TipRate       = 0.15;

			//
			// Items purchased by customer
			//
			int numSodas      = 2;
			int numSandwiches = 2;
			int numChips      = 1;

			//
			// Calculations
			//
			double sodaTotal     = numSodas      * SodaPrice;
			double sandwichTotal = numSandwiches * SandwichPrice;
			double chipsTotal    = numChips      * ChipsPrice;

			double subtotal = sodaTotal + sandwichTotal + chipsTotal;

			double tax = subtotal * TaxRate;
			double tip = subtotal * TipRate;

			double total = subtotal + tax + tip;

			//
			// Output: the "C" in the format specification "{0:C}" stands for "currency"
			// and will include your local currency symbol in the printed output.
			//
			Console.WriteLine("Subtotal {0:C}", subtotal);
			Console.WriteLine("Tax      {0:C}", tax);
			Console.WriteLine("Tip      {0:C}", tip);
			Console.WriteLine("TOTAL    {0:C}", total);
		}
	}
}
