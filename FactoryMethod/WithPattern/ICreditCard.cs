using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.WithPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
