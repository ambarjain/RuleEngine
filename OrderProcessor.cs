using System;
using System.Collections.Generic;

namespace BusinessRulesEngine
{
    public class OrderProcessor
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        protected List<IPurchaseRule> payments;
        protected IEmail email;
        //    protected List<IPurchaseRule> payments = new List<IPurchaseRule>();
        //    public string ProductType { get; set; }
        public OrderProcessor(List<IPurchaseRule> payments)
        {
            this.payments = payments;
        }
        public void ProcessOrder(Product product)
        {
            foreach (var payment in payments)
                Console.WriteLine(payment.ExecutePaymentRule(product));
            
        }
    }
}