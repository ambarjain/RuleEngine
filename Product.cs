using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public abstract class Product
    {
        private int productId;
        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }

        private double cost;
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public int Quantity { get; set; }


                                           //    protected IPurchaseRule payment;
                                           //    protected IEmail email;
                                           ////    protected List<IPurchaseRule> payments = new List<IPurchaseRule>();
                                           ////    public string ProductType { get; set; }
                                           //    public string ProcessOrder()
                                           //    {
                                           //        return payment.ExecutePaymentRule();
                                           //    }

        //    //If we need to change the behavior at run time
        //    public void setDifferentPaymentMethod(IPurchaseRule payment)
        //    {
        //        this.payment = payment;
        //    }
    }
}
