using System;
using System.Collections.Generic;

namespace BusinessRulesEngine
{
    class Order
    {
        
        
        //create order class and seed it hardcoded
        //payment is done
        //order line item--product name
        //order entity is main entity. it contains products
        //attribute 
        //not able to add new product
        //need to pass actual params
        //Order contatins product
        //Order processing class--ProcessORder()
        //Rules are applied to product --correct
        //Inputs to my function--required in future
        //Pass product time being as input
        //Product depends on payment--payement depends on product--cyclic dependency
        static void Main(string[] args)
        {
            OrderProcessor order;
            List<IPurchaseRule> payments=new List<IPurchaseRule>();
            Console.WriteLine("Select Product you want to purchase:\n");
            Console.WriteLine("1. Physical Product");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Membership");
            Console.WriteLine("4. Video");

            int productNumber = int.Parse(Console.ReadLine());

            if (productNumber == 1)
            {
               
                Console.WriteLine("Purchased a physical product");
                Product physicalProduct = new PhysicalProduct();
                payments.Add(new PackingSlipRule());
                payments.Add(new CommissionPaymentRule());
                order = new OrderProcessor(payments);
                order.ProcessOrder(physicalProduct);
                
                //Console.WriteLine(physicalProduct.ProcessOrder()); //dopayment to process order.  if order is a seperate class. Should we have order processor class. have processorder method
                                                                   //  physicalProduct.setDifferentPaymentMethod(new CommissionPaymentRule());
                //Console.WriteLine(physicalProduct.ProcessOrder() + "\n");
            }
            else if (productNumber == 2)
            {
                Console.WriteLine("Purchased a book");
                Product bookProduct = new BookProduct();
                payments.Add(new DuplicatePackingSlipRule());
                payments.Add(new CommissionPaymentRule());
                order = new OrderProcessor(payments);
                order.ProcessOrder(bookProduct);
                //Console.WriteLine(bookProduct.ProcessOrder());
                ////  bookProduct.setDifferentPaymentMethod(new CommissionPaymentRule());
                //Console.WriteLine(bookProduct.ProcessOrder() + "\n");
            }
            else if (productNumber == 3)
            {
                Console.WriteLine("Press 1 if you want to activate.\n Press 2 if you want to upgrade");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    Console.WriteLine("Purchased a new membership");
                    Product membership = new Membership("new");
                    payments.Add(new ActivateMembershipRule());
                    order = new OrderProcessor(payments);
                    order.ProcessOrder(membership);
                    //  Console.WriteLine(membership.ProcessOrder() + "\n");
                }
                else if (selection == 2)
                {
                    Console.WriteLine("Purchase made for upgrading a membership");
                    Product membershipUpgrade = new Membership("upgrade");
                   
                    payments.Add(new UpgradeMembershipRule());
                    order = new OrderProcessor(payments);
                    order.ProcessOrder(membershipUpgrade);
                    //Console.WriteLine(membershipUpgrade.ProcessOrder() + "\n");
                }
            }
            else if (productNumber == 4)
            {
                Console.WriteLine("Purchased a Video");
                Product video = new LearningToSki();
                payments.Add(new FreeFirstAidVideoRule());
                order = new OrderProcessor(payments);
                order.ProcessOrder(video);
                //  Console.WriteLine(video.ProcessOrder() + "\n");
            }
        }
    }
}
