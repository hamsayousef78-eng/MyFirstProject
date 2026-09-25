using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public class Developer : Employee, IReportable
    {
        private decimal _overtime;
        public decimal overtime
        {
            get
            {
                return _overtime;
            }
            private set
            {
                if (value < 0)
                {
                    _overtime = 0;
                }
                else
                {
                    _overtime = value;
                }
            }
        }
        //constructor  
        public Developer(int id, string name, string email,decimal baseSalary, decimal overtime)
          : base(id, name,email,baseSalary)
        {
            this.overtime = overtime;
        }
        //calSalary
        public override decimal calSalary()
        {
            return baseSalary + overtime;
        }
        //printInfo
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine(
             $" overtime : {overtime}\n" +
             $" total salary  : {calSalary()}"
             );
        }
        //GenerateReport
        public void GenerateReport()
        {
            Console.WriteLine($"developer {name} generate report");
        }
    }
}
