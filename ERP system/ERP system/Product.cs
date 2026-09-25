using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _price;
        private int _stockQuantity;
        public int id { get; }
        public string name
        {
            get
            {
                return _name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("unknown");
                }
                _name = value;
            }
        }
        public decimal price
        {
            get 
            { 
                return _price; 
            }
            private set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }
        public int stockQuantity
        {
            get 
            { 
                return _stockQuantity;
            }
            private set
            {
                if (value < 0)
                {
                    _stockQuantity = 0;
                }
                else
                {
                    _stockQuantity = value;
                }
            }
        }
        //constructor 
        public Product(int id, string name, decimal price, int stockQuantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.stockQuantity = stockQuantity;
        }
        //Add Product
        public void addProduct()
        {

        }
        //Update Price
        public void updatePrice(decimal newPrice)
        {
            //codeApprove
            if(newPrice<0)
            {
                return;
            }
            price = newPrice;
        }
        //Increase Stock
        public void increaseStock(int quantity)
        {
            if (quantity <= 0)
            {
                return;
            }
            stockQuantity += quantity;
        }
        //Decrease Stock
        public bool decreaseStock(int quantity)
        {
            if (quantity <= 0)
            {
                return false;
            }
            if (quantity > stockQuantity)
            {
                return false;
            }
            stockQuantity -= quantity;
            return true;
        }

        //Print Product Info
        public void printInfo()
        {
            Console.WriteLine(
                 $" product id : {id}\n" +
                 $" name : {name}\n" +
                 $" price : {price}\n" +
                 $" StockQuantity : {stockQuantity}"
                 );
        }
    }
}
