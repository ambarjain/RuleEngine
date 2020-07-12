namespace BusinessRulesEngine
{
    internal class UpgradeMembershipRule : IPurchaseRule
    {
        public string ExecutePaymentRule(Product product)
        {
            return "Upgrading Membership";
        }
    }
}