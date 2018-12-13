using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6P2
{
    class Customer
    {
        public const decimal VIPDiscountRate = 0.10m;
        public const decimal memberDiscountRate = 0.05m;
        private string customerId;
        private string customerName;
        private decimal accumulatedPurchase;
        private decimal currentPurchaseAmount;

        // properties
        public string CustomerId { get { return customerId; } set { customerId = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public decimal AccumulatedPurchase { get { return accumulatedPurchase; } set { accumulatedPurchase = value; } }
        public decimal CurrentPurchaseAmount { get { return currentPurchaseAmount; } set { currentPurchaseAmount = value; } }

        // constructor
        public Customer(string customerId, string customerName)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            accumulatedPurchase = 0.0m;
        }

        // methods
        public virtual void MakePurchase(decimal purchaseAmount)
        {
            if (purchaseAmount > 0)
            {
                AccumulatedPurchase += purchaseAmount;
            }
        }
        public override string ToString()
        {
            string str;
            str = string.Format($"{CustomerName}: Total Purchase this year {AccumulatedPurchase:C}");
            return str;
        }

    }
}
