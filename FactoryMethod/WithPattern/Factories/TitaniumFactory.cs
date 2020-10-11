using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.WithPattern.Factories
{
    class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard platinumCard = new Platinum();
            return platinumCard;
        }
    }
}
