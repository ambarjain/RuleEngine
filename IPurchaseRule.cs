namespace BusinessRulesEngine
{
    public interface IPurchaseRule
    {
        string ExecutePaymentRule(Product product);
    }
}