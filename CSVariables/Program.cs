using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVariables
{
    /*
     * Declare  and intiailize variables of the following type:
     * string, int, char, bool, double, decimal.
     * Interpolate these variables in a Console.WriteLine();
     * 
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            string prodName = "magic beans";
            int numEasyPayments = 37;
            char model = 'F';
            bool freeShipping = false;
            double orderSubTotal = 999.99;
            double shippingFees = 0.01;
            decimal shippingWeight = 0.000001m;
            double orderTotal = orderSubTotal + shippingFees;
            double amountPerPayment = Math.Round(orderTotal / numEasyPayments, 2);

            Console.WriteLine($"Thank you for purchasing the {prodName} model {model}!\nHere is your order summary:");
            Console.WriteLine($"\tSubTotal:       ${orderSubTotal}");
            Console.WriteLine($"\tFree Shipping:   {freeShipping}");
            Console.WriteLine($"\tShipping Weight: {shippingWeight} lbs");
            Console.WriteLine($"\tShipping Fees:  ${shippingFees}");
            Console.WriteLine($"\tOrder Total:    ${orderTotal}: {numEasyPayments} payments of ${amountPerPayment}.\nThank you for shopping with us!");

        }
    }
}
