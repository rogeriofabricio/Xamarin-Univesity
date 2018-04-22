using System;

namespace Fundamentals
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int myAge   = 22;
			int yourAge = 35;

			const int retirement = 65;

			string message = "Will we be ready to retire soon?";

			myAge = 59; // variable can change its value

			/*
			 * Use subtraction to calculate years-to-retirement
			 */
			int yearsToRetirementForYou = retirement - yourAge;
			int yearsToRetirementForMe  = retirement - myAge;

			/*
			 * Print the value of a variable
			 */
			Console.WriteLine(message);

			Console.WriteLine("Years for you: " + yearsToRetirementForYou); // concatenating strings
			Console.WriteLine("Years for me: {0}", yearsToRetirementForMe); // formatting strings
		}
	}
}