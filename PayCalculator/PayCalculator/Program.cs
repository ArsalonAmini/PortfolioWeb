using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal hours;
            decimal wages;
            decimal gross;

            Console.Write("Enter Hours:"); // Prompt 
            string hoursWorked = Console.ReadLine();
            Console.Write("Enter rate:"); // Prompt  
            string hourlyWage = Console.ReadLine();

            hours = Decimal.Parse(hoursWorked);
            wages = Decimal.Parse(hourlyWage);
            gross = hours * wages;
            Console.WriteLine("Your grosss pay:" + gross);
     
            
        }
    }
}
