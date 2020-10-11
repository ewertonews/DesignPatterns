using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern.WithoutPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
