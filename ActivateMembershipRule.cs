namespace BusinessRulesEngine
{
    internal class ActivateMembershipRule : IPurchaseRule
    {
        public string ExecutePaymentRule(Product product)
        {
            return "Activating Membership";
        }
    }
}