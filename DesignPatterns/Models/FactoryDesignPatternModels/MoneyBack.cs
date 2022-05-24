using DesignPatterns.Interface.FactoryDesignPatternInterface;

namespace DesignPatterns.Models.FactoryDesignPatternModels
{
    class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }

}
