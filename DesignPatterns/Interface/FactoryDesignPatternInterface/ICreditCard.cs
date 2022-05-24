namespace DesignPatterns.Interface.FactoryDesignPatternInterface
{

    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

}
