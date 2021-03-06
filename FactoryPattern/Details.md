﻿## Real-Life Example of Factory Pattern:

From Lehman’s point of view, we can say that a factory is a place where products are created. In order words, we can say that it is a centralized place for creating products. Later, based on the order, it received, the appropriate product is delivered by the factory.

For example, a car factory can produce different types of cars. If you are ordering a car to the car factory, then based on your requirements or specifications, the factory will create the appropriate car and then delivered that car to you.

The same thing also happens in the factory design pattern. A factory (i.e. a class) will create and deliver products (i.e. objects) based on the incoming parameters.

When to use the Factory Design Pattern in real-time applications?
It would not be a good programming approach to specify the exact class name while creating the objects by the client which leads to tight coupling between the client and the product. To overcome this problem, we need to use the Factory Design Pattern in C#.

This design pattern provides the client with a simple mechanism to create the object. So, we need to use the Factory Design Pattern in C# when

1. The Object needs to be extended to the subclasses
2. Classes don’t know what exact sub-classes it has to create
3. The Product implementation going to change over time and the Client remains unchanged

### Problems of Simple Factory Pattern in C#

If we need to add any new product (i.e. new credit card) then we need to add a new if else condition in the GetCreditCard method of the CreditCardFactory class. This violates the open/closed design principle.
We also have a tight coupling between the Factory (CreditCardFactory) class and product classes (MoneyBack, Titanium, and Platinum).
In the next article, I am going to discuss how to overcome the above problem by using the Factory Method Design Pattern in C#. Here, in this article, I try to explain the Factory Pattern in C# with an example. I hope this article will help you with your needs. I would like to have your feedback. Please post your feedback, question, or comments about this article.

source: https://dotnettutorials.net/lesson/factory-design-pattern-csharp