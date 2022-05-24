using DesignPatterns;
using DesignPatterns.Interface.FactoryDesignPatternInterface;
using System;
using System.Collections.Generic;

namespace CodingPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] Input = { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
            //PrintMajorityElements(Input);

            #region CreationalDesignPattern

            #region SingletonPattern
            SingletonPattern fromTeachaer = SingletonPattern.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            SingletonPattern fromStudent = SingletonPattern.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
            #endregion

            #region FactoryPattern
            ICreditCard cardDetails = FactoryDesignPattern.GetCreditCard("Platinum");

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
            #endregion



            #endregion

            #region StructuralDesignPattern

            #region AdapatorPattern

            #endregion

            #endregion

        }


        public static void PrintMajorityElements(int[] numbers)
        {
            /*  Write a function which takes an array and prints the majority element(if it exists), otherwise prints “No Majority Element”.
             *  A majority element in an array A[] of size n is an element that appears more than n / 2 times(and hence there is at most one such element).

          Examples : 

         Input: { 3, 3, 4, 2, 4, 4, 2, 4, 4}
             Output: 4
         Explanation: The frequency of 4 is 5 which is greater
         than the half of the size of the array size.*/


            //Find half of the array size to get the majority element
            //Take and elements and loop it against the other elements ..keep and counter to track

            int half_of_the_array = numbers.Length / 2;

            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                keyValues.Add(i,counter);
                counter = 0;
            }

            foreach (var item in keyValues)
            {
                if(item.Value >= half_of_the_array)
                    Console.WriteLine(numbers[item.Key] +" ---> "  + item.Value);
            }

        }
    }


    
}
