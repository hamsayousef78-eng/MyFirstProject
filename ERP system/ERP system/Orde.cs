using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public class Order
    {
        //properties
        public int id { get;}
        public Customer customer { get;}
        public orderItem[] items { get; }//===== private readonly orderItem[] _items ;
        public decimal total { get; private set; }
        public orderStatus status { get; private set; }
        private readonly Ipayment _payment;

        //constructor 
        public Order(int id, Customer customer,Ipayment payment)
        {
            this.id = id;
            this.customer = customer;
            items = new orderItem[10];
            total = 0;
            status =orderStatus.pending;
            this._payment = payment;
        }
        //Add item
        public bool addItem(orderItem item)
        {
            if (item == null)
            {
                return false;
            }
            for(int i = 0; i < items.Length;i++)
            {
                if (items[i] == null)
                {
                    items[i]= item;
                  //  calOrderTotal();//لي بعملها هنا
                    return true;
                }
            }
            return false;//order is full مفيش مكان اضيف في اي item
        }
        //cal order total
        public decimal calOrderTotal()
        {
            total = 0;//لي لو ما حطتهاش يحصل مشكله
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    total = total + items[i].calItemTotal();
                }
            }
            return total;
        }
        
        //Confirm Order
        public void confirmOrder()
        {
            status = orderStatus.confirmed;
        }
        //paid Order
        public void paidOrder()
        {
            status = orderStatus.paid;
        }
        //complete Order
        public void completeOrder()
        {
            status = orderStatus.completed;
        }
        //Cancel Order
        public void cancelOrder()
        {
            status = orderStatus.cancelled;
        }
        //Print orde Info
        public void printInfo()
        {
            Console.WriteLine(
                 $" order id : {id}\n" +
                 $" customer : {customer.name}\n" +
                 $" status : {status}\n" +
                 $" order total : {calOrderTotal()}"//total هتيجي ازاي
                 );
        }
        //print items
        public void PrintItems()
        {
            Console.WriteLine("Order Items:");

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine($"Item #{i + 1}");

                    items[i].printInfo();

                    Console.WriteLine();
                }
            }
        }
        //process payment
        public void processPayment()
        {
            _payment.process(total);
        }
    }
    //order status
    public enum orderStatus
    {
        pending,
        confirmed,
        paid,
        completed,
        cancelled
    }
}
