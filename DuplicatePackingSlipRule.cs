using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public class DuplicatePackingSlipRule : IPurchaseRule
    {
        public string ExecutePaymentRule(Product product)
        {
            return "Generating Duplicate Packing SLip for Royalty Department";
        }
    }
}
