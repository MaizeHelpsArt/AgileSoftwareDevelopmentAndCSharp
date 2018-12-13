using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6P2
{
    class MemberCustomer : Customer
    {
        // constructor
        public MemberCustomer(string employeeId, string employeeName) : base(employeeId, employeeName) { }

        // override MakePurchase()
        public override void MakePurchase(decimal purchaseAmount)
        {
            if (purchaseAmount > 0.0m)
            {
                CurrentPurchaseAmount = purchaseAmount;
                base.MakePurchase(purchaseAmount * (1.0m - memberDiscountRate));
            }
        }
        // ToString() method
        public override string ToString()
        {
            string str;
            str = base.ToString() + string.Format($" You saved {CurrentPurchaseAmount * memberDiscountRate:C} as a member.");
            if (AccumulatedPurchase > 1000m)
            {
                str += string.Format("\nYou are qualified as a VIP customer. Please talk to a manager.");
            }
            return str;
        }
    }
}
