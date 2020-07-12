namespace BusinessRulesEngine
{
    internal class PackingSlipRule : IPurchaseRule
    {
        public string ExecutePaymentRule(Product product)
        {
            return "Generating Packing Slip";
        }
    }
}