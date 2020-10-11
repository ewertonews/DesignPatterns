using DesignPatterns.FactoryPattern.WithoutPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern.WithPattern
{
    class ClientPattern
    {
        public void CreditCardPattern()
        {
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
