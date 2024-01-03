/* 
 * Program.cs
* Demo of getting inputs, converting values,
* performing calculations, and formatting output
* 
* Revision History:
*     Jenil Gohel, Created :  2023.09.19
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            string name;
            double payRate;
            double hours;
            double preTax;
            double taxRate = 0.19;
            double taxAmount;
            double earned;

            //get values from user
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter rate of pay: ");
            payRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter hours worked: ");
            hours = Convert.ToDouble(Console.ReadLine());

            //calculations
            preTax = payRate * hours;
            taxAmount = preTax * taxRate;
            earned = preTax - taxAmount;

            //show outputs
            Console.WriteLine($"\nPay Calculation for: {name}");
            Console.WriteLine($"Rate of Pay:    {payRate}");
            Console.WriteLine($"Hours Worked:   {hours}");
            Console.WriteLine($"Pre-tax amount: {preTax.ToString("C")}");
            Console.WriteLine($"Tax Amount:     {taxAmount.ToString("C")}");
            Console.WriteLine($"Take Home Pay:  {earned.ToString("C")}");

            Console.ReadKey();
        }
    }
}