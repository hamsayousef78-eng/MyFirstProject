using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public class Manager : Employee, IApprovable, IReportable
    {
        private decimal _bouns;
        public decimal bouns
        {
            get
            {
                return _bouns;
            }
            private set
            {
                if (value < 0)
                {
                    _bouns = 0;
                }
                else
                {
                    _bouns = value;
                }
            }
        }
        //constructor 
        public Manager(int id, string name, string email, decimal baseSalary, decimal bouns)
         : base(id, name, email, baseSalary)
        {
            this.bouns = bouns;
        }
        //calSalay
        public override decimal calSalary()
        {
            return baseSalary + bouns;
        }
        //printBaseInfo
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine(
             $" bouns : {bouns}\n" +
             $" total salary: {calSalary()}"
             );
        }
        //ApproveOrder
        public void ApproveOrder()
        {
            Console.WriteLine($"manager {name} approved order");
        }
        //GenerateReport
        public void GenerateReport()
        {
            Console.WriteLine($"manager {name} generate report");
        }
    }

}
