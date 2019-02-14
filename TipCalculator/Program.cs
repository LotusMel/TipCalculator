using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Want total of the bill before tip, the percentage options for a tip,
                Ask user total bill amount*/

            Console.WriteLine("What is your bill amount?: ");
            string billInput = Console.ReadLine();

            //billinput = billinput.Trim();
            //billInput = billInput.Trim('$');

            billInput = billInput.Trim();
            billInput = billInput.Trim('$');



            
            // Ask user what percentage they want to tip

            Console.WriteLine("What percentage would you like to tip?: ");
            string tipPercentInput = Console.ReadLine();
            //tipPercentInput = tipPercentInput.Trim();
            //tipPercentInput = tipPercentInput.Trim('%');

            tipPercentInput = tipPercentInput.Trim().Trim('%');

            // Read Bool and Parse
            double tipPercent;
            double bill;
            if(!double.TryParse(tipPercentInput, out tipPercent)){
                Console.WriteLine($"The value {tipPercentInput} is not a valid tip.");
            }
            if(double.TryParse(billInput, out bill))
            {
                Console.WriteLine($"The value {billInput} is not a valid bill amount");
                Console.ReadLine();
                return;
            }


            //double bill = double.TryParse(billInput, 2);


            //int tipPercent = int.Parse(tipPercentInput);
            
            /*Calculate the percentage of the bill 
                to render tip amount
                */
            double tipAmount = tipPercent * bill / 100;
            double totalBill = Math.Round(bill + tipAmount, 2);

            //and the total of bill after the tip


            double roundedTipAmount = Math.Round(tipAmount, 2);
            //totalBill = Math.Round(totalBill, 2);
                


            string tipAmountString = tipAmount.ToString();

            Console.WriteLine($"Your tip amount is ${tipAmount}.");
            Console.WriteLine($"Your total bill is ${totalBill}.");
            Console.ReadLine();
            
            /*If statement for tip options
             10%
             15%
             20%
             None

            Formula: Tip == Bill * percentage (10, 15, or 20)%
                     TotalBill == Bill + Tip
             */

        }
    }
}
