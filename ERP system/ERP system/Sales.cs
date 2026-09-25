using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public class Sales : Employee, INotifiable
    {
        //auto property 
        private decimal _commission;
        public decimal commission
        {
            get
            {
                return _commission;
            }
            private set
            {
                if (value < 0)
                {
                    _commission = 0;
                }
                else
                {
                    _commission = value;
                }
            }
        }
        //constructor 
        public Sales(int id, string name, string email, decimal baseSalary, decimal commission)
         : base(id, name, email, baseSalary)
        {
            this.commission = commission;
        }
        //calSalary
        public override decimal calSalary()
        {
            return baseSalary + commission;
        }
        //printBaseInfo
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine(
             $" commission : {commission}\n" +
             $" total salary: {calSalary()}"
             );
        }
        //SendNotification
        public void SendNotification()
        {
            Console.WriteLine($"sales {name} send notification");
        }
    }
}
