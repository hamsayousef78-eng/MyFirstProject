using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system.DB
{
    public class InMemoryCustomerListRepo:ICustomerRepo
    {
        private readonly  List<Customer> _customers;
        public InMemoryCustomerListRepo()
        {
            _customers = new List<Customer>() ;
        }
        //Add new cutomer
        public bool Add(Customer customer)
        {
            _customers.Add(customer);
            return true;
        }
        //Find cutomer by id
        public Customer FindById(int id)
        {
            for(int i=0;i< _customers.Count;i++)
            {
                if(_customers[i].id==id)
                {
                    return _customers[i];
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
            return _customers;
        }
      
    }
}
