using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system.DB
{
    public class InMemoryCustomerRepo:ICustomerRepo
    {
        private InMemoryDatabase _database;
        public InMemoryCustomerRepo(InMemoryDatabase database)
        {
            _database = database;
        }
        //Add new cutomer
        public bool Add(Customer customer)
        {
             for(int i=0;i< _database.Customers.Length;i++)
            {
                if (_database.Customers[i] ==null)
                {
                    _database.Customers[i] = customer;
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
