using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Tipper tipper = new Tipper(); // instance of the tipper class

            while (true) // "forever" loop 
            {
                Console.Write("Please enter the total bill: ");
                tipper.total_bill = double.Parse(Console.ReadLine());

                Console.Write("B)ad tip O)k tip G)ood Tip D)ivvy the bill Q)uit: ");
                char operation = Console.ReadLine().ToUpper()[0];

                if(operation == 'B')
                {
                    double total_bad = tipper.CalculateTip(.1);
                    Console.WriteLine("It was a bad tip, the total is: " + total_bad);
                }
                else if(operation == 'O')
                {
                    double total_okay = tipper.CalculateTip();
                    Console.WriteLine("It was a okay tip, the total is: " + total_okay);
                }
                else if(operation == 'G')
                {
                    double total_good = tipper.CalculateTip(.2);
                    Console.WriteLine("It was a good tip, the total is: " + total_good);
                }
                else if(operation == 'D')
                {
                    Console.Write("How many people are there?: ");
                    tipper.total_people = int.Parse(Console.ReadLine());

                    Console.WriteLine("The total was: " + tipper.Divvy(tipper.total_people));
                }
                else if(operation == 'Q')
                {
                    break;
                }
            }
        }
    }
}
