﻿namespace BusinessRulesEngine
{
    internal class FreeFirstAidVideoRule : IPurchaseRule
    {
        public string ExecutePaymentRule(Product product)
        {
            return "Adding free \'First Aid\' Video with Packing Slip";
        }
    }
}