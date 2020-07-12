namespace BusinessRulesEngine
{
    public class CommissionPaymentRule : IPurchaseRule
    {
        public string ExecutePaymentRule(Product product)
        {
            return "Commission Payment to Agent";
        }
    }
}