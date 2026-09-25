using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public class HR : Employee, IApprovable, INotifiable
    {
        private decimal _allowance;
        public decimal allowance
        {
            get
            {
                return _allowance;
            }
            private set
            {
                if (value < 0)
                {
                    _allowance = 0;
                }
                else
                {
                    _allowance = value;
                }
            }
        }
        //constructor 
        public HR(int id, string name, string email, decimal baseSalary, decimal allowance)
          : base(id, name, email, baseSalary)
        {
            this.allowance = allowance;
        }
        //calSalary
        public override decimal calSalary()
        {
            return baseSalary + allowance;
        }
        //printInfo
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine(
             $" allowance : {allowance}\n" +
             $" total salary: {calSalary()}"
             );
        }
        //ApproveOrder
        public void ApproveOrder()
        {
            Console.WriteLine($"HR {name} approved order");
        }
        //SendNotification
        public void SendNotification()
        {
            Console.WriteLine($"HR {name} send notification");
        }
    }
}
