using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall
{
    interface Payment
    {
        double discount(double amount);
    }
    class MembershipCard : Payment

    {
        double dis = 0.1;
        public double discount(double amount) {
            Console.WriteLine("You Have MemberShip Card");
            return amount * (1 - dis);


        }
    }
     class EmployeeCard : Payment
    {
        double dis = 0.2;
        public double discount(double amount)
        {
            Console.WriteLine("Employee Card");
            return amount * (1 - dis);
        }
    }

    class NoCard : Payment
    {
        //double dis = 0.2;
        public double discount(double amount)
        {
            Console.WriteLine("No Card");
            return amount;
        }
    }

    class DiscountFactory
    {
        public static Payment GetDiscount(string cardType)
        {
            switch (cardType)
            {
                case "Membership Card":
                    return new MembershipCard();
                case "Employee Card":
                    return new EmployeeCard();
                default:
                    return new NoCard();
            }

        }

        //class CardType
        //{
        //    static void Main(string[] args)
        //    {
        //        string customerCardType = "Membership Card"; 
        //        double amount = 100.0; 
        //        Payment discount = DiscountFactory.GetDiscount(customerCardType);
        //        double discountedAmount = discount.discount(amount);
        //        Console.WriteLine("Discounted amount: " + discountedAmount);
        //    }
        //}

    }

}
