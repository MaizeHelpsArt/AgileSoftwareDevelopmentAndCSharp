using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6P2
{
    class VIPCustomer : Customer
    {
        // constructor
        public VIPCustomer(string customerId, string customerName) :base(customerId, customerName) { }

        //overide MakePurchase() method
        public override void MakePurchase(decimal purchaseAmount)
        {
           if (purchaseAmount > 0m && AccumulatedPurchase > 1000m)
            {
                CurrentPurchaseAmount = purchaseAmount;
                base.MakePurchase(purchaseAmount * (1 - VIPDiscountRate));
            }
           else if (purchaseAmount > 0m)
            {
                CurrentPurchaseAmount = purchaseAmount;
                base.MakePurchase(purchaseAmount);
            }
        }
        // override to string
        public override string ToString()
        {
            string str;
            str = base.ToString();
            if (AccumulatedPurchase >= 1000m)
            {
                str += string.Format($" You saved {CurrentPurchaseAmount * VIPDiscountRate:C} as a VIP.");
            }
            return str;
        }
    }
}
