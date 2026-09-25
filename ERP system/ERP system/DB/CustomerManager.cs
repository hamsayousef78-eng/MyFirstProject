using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system.DB
{
    public class CustomerManager
    {
        private ICustomerRepo _repo;
        public CustomerManager(ICustomerRepo repo)
        {
            _repo=repo;
        }
        //Add new cutomer
        public bool Add(Customer customer)
        {
            return _repo.Add(customer);
        }
        //Find cutomer by id
        public Customer FindById(int id)
        {
            return _repo.FindById(id);
        }
        //Update customer
        public bool update(int id, string name, string email, string phone)
        {
           return _repo.update(id, name, email, phone);
        }
      
         // Display all customers
        public void DisplayAll()
        {
            IEnumerable<Customer> customers = _repo.GetAll(); // Get all customers from the repository  array or list

            foreach (var customer in customers)
            {
                if (customer != null)
                {
                    Console.WriteLine($"ID: {customer.id}, Name: {customer.name}, Email: {customer.email}, Phone: {customer.phone}");
                }
            }

        }
       
    }
}
