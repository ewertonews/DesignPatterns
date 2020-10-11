using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.WithPattern.Factories
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}
