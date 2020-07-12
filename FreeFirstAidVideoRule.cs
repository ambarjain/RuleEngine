namespace BusinessRulesEngine
{
    internal class FreeFirstAidVideoRule : IPurchaseRule
    {
        public string ExecutePaymentRule(Product product)
        {
            return "Adding new First Aid Video";
        }
    }
}