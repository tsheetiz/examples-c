using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculation
{
    public class Tipper
    {
        public double total_bill;
        public int total_people;

        public double CalculateTip(double tip_percentage)
        {
            return tip_percentage * total_bill;
        }

        /*
         * Note that this is method overloading since the two CalculateTip methods have the same name. 
         * This is legal in C# since the parameter lists are different (i.e. one of the methods takes 1 parameter and the other takes 0 parameters). 
        */

        public double CalculateTip()
        {
            return total_bill * (.15);
        }

        public double Divvy(int number_of_diners)
        {
            double total_amount = total_bill / number_of_diners;

            return total_amount;

            //It must take an int parameter which specifies the number of diners, calculate the amount each should pay if the bill is split evenly, and return that amount.
        }
    }

    // test
}
