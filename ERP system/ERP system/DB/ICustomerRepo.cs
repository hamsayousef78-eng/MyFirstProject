using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system.DB
{
    public interface ICustomerRepo
    {
        bool Add(Customer customer);
        Customer FindById(int id);
        bool update(int id, string name, string email, string phone);
        IEnumerable<Customer> GetAll();
    }
}
