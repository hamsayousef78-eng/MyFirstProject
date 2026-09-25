using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ERP_system
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        //properties
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
        public string email
        {
            get
            {
                return _email;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("email is required");
                }
                _email = value;
            }
        }
        public string phone
        {
            get
            {
                return _phone;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("not provided");
                }
                _phone = value;
            }
        }
        //constructor 
        public Customer(int id, string name, string email, string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
        //Add Customer
        public void addCustomer()
        {

        }
        //Update Customer
        public void updateCustomer(string name, string email, string phone)
        {
            name = name;
            email = email;
            phone = phone;
        }
        //Print Customer Info
        public void printInfo()
        {
            Console.WriteLine(
                 $" customer id : {id}\n" +
                 $" name : {name}\n" +
                 $" Email : {email}\n" +
                 $" phone : {phone}"
                 );
        }
    }
}
