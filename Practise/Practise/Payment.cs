using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public delegate void PaymentDelegate(decimal amount);

    class Payment
    {
        public static void PayByCard(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Card");
        }

        public static void PayByUPI(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using UPI");
        }
    }

}
