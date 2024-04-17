namespace ShoppingMall
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shopping Mall");
            Console.WriteLine();
            Console.WriteLine("Enter the Total Amount");
            string am=Console.ReadLine();
            int amount=Convert.ToInt32(am);

            Console.WriteLine();
            Console.WriteLine("Enter the type of Card");
            Console.WriteLine("Membership Card");
            Console.WriteLine("Employee Card");
            Console.WriteLine("No Card");

            
            string Card=Console.ReadLine();
            Console.WriteLine();
            //string customerCardType = "Membership Card";
            //double amount = 100.0;
            Payment discount = DiscountFactory.GetDiscount(Card);
            double discountedAmount = discount.discount(amount);
            Console.WriteLine();
            Console.WriteLine("You Have To Pay");
            Console.WriteLine("Discounted amount: " + discountedAmount);

        }
    }
}
