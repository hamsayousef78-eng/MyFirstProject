using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system.DB
{
    public class InMemoryDatabase
    {
        public Employee[] Employees { get; } = new Employee[20];
        public Customer[] Customers { get; } = new Customer[20];
        public Product[] Products { get; } = new Product[20];
        public Order[] Orders { get; } = new Order[20];
    }
}
