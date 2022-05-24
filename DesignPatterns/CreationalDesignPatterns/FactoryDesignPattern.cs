using DesignPatterns.Interface.FactoryDesignPatternInterface;
using DesignPatterns.Models.FactoryDesignPatternModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    /*
     * According to Gang of Four, the Factory Design Pattern states that “A factory is an object which is used for creating other objects”. 
     * In technical terms, we can say that a factory is a class with a method. 
     * That method will create and return different types of objects based on the input parameter, it received.
     * In simple words, if we have a superclass and n number of subclasses, and based on the data provided,
     * if we have to create and return the object of one of the subclasses, then we need to use the Factory Design Pattern in C#.
     * */

    public static class FactoryDesignPattern
    {


        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            return cardDetails;
        }


    }
}
