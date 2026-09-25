using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system.DB
{
    public class InMemoryRepo<E,T>:IRepo<T>
    {
        private E _database;

        //Add
        public bool Add(T value)
        {
             for(int i=0;i< _database.Length;i++)
            {
                if (_database ==null)
                {
                    _database = value;
                    return true;
                }
            }
             return false;
        }
        //Find cutomer by id
        public Customer FindById(int id)
        {
            foreach(var customer in _database.Customers)
            {
                if(customer !=null && customer.id==id)
                {
                    return customer;
                }
            }
            return null;
        }
        //Update customer
        public bool update(int id, string name, string email, string phone)
        {
            Customer customer = FindById(id);
            if(customer==null)
            {
                return false;
            }
            customer.updateCustomer(name, email, phone);
            return true;
        }
        public IEnumerable<Customer> GetAll()
        {
            return _database.Customers;
        }

    }
}
