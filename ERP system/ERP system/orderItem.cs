using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ERP_system
{
    public class orderItem
    {
        public Product product { get;  }
        public int quantity { get;  }
        public decimal unitPrice { get; }
        //constructor 
        public orderItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
            this.unitPrice = product.price;
        }
        //cal item total
        public decimal calItemTotal()
        {
            return quantity * unitPrice;
        }

        //Print orde item Info
        public void printInfo()
        {
            Console.WriteLine(
                 $" product : {product.name}\n" +
                 $" quantity : {quantity}\n" +
                 $" unitPrice : {unitPrice}\n" +
                 $" item total : {calItemTotal()}"
                 );
        }
    }
}
