namespace ERP_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Manager m=new Manager(1,"hamsa","hamsa@gmail",3000,5000);
            Customer c = new Customer(1, "mena", "mena@gmail", "010172172781");
            Product p = new Product(1, "tablet", 3000, 100);
            Product p1 = new Product(2, "phone", 2000, 100);
            Product p2 = new Product(3, "pc", 4000, 100);
            orderItem o = new orderItem(p, 2);
            orderItem o1 = new orderItem(p1, 3);
            orderItem o2 = new orderItem(p2, 5);
            Ipayment payment1 = new CashPayment();
            Ipayment payment2 = new BankTransferPayment();
            Ipayment payment3 = new CreditCardPayment();
            Order or = new Order(1, c, payment1);
            or.addItem(o);
            or.addItem(o1);
            or.addItem(o2);
           or.printInfo();
            Console.WriteLine("---------------------------------");
            or.PrintItems();
            Console.WriteLine("---------------------------------");
           or.processPayment();



        }
    }
}
