using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public abstract class Employee
    {
        private int _id;
        private string _name;
        private string _email;
        private decimal _baseSalary;
        //properties
        public int id { get; }//read only properties
        public string name
        {
            get
            {
                return _name;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("name is required");
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
        public decimal baseSalary
        {
            get 
            { 
                return _baseSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("base salary can not be negtive");
                }
                else
                {
                    _baseSalary = value;
                }
            }
        }
        //constructor 
        public Employee(int id, string name, string email, decimal baseSalary)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.baseSalary = baseSalary;
        }
        //calSalary
        public abstract decimal calSalary();
        //printInfo
        public virtual void printInfo()
        {
            Console.WriteLine(
                 $" id : {id}\n" +
                 $" name : {name}\n" +
                 $" Email : {email}\n" +
                 $" base salary : {baseSalary}"
                 );
        }
    }
}
