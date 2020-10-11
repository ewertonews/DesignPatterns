using DesignPatterns.FactoryPattern.WithoutPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern.WithoutPattern
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
