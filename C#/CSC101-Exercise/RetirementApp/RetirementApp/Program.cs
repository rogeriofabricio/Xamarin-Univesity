using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementApp
{
    class Program
    {
        static void Main(string[] args)
        {

            const int retirement = 65;

            int myAge = 25;
            int yourAge = 35;

            string message = "Will we be ready to retire soon?";

            int yearsToRetirementForYou = retirement - yourAge;
            int yearsToRetirementForMe = retirement - myAge;

            Console.WriteLine(message);

            Console.WriteLine("Years for you: " + yearsToRetirementForYou);
            Console.WriteLine("Years for me: {0}", yearsToRetirementForMe);

        }
    }
}
