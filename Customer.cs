using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        [Max(10)]
        public int PhoneNumber { get; set; }
        [Email]
        public string Email { get; set; }
        public string BillingAddress { get; set; }
        
        public string ShippingAddress { get; set; }
    }
}
