using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    class EmployeeMobile: Employee
    {
        public EmployeeMobile(string _fullName, int _time, int _complOrders = 0): base (_fullName, _time, _complOrders)
        {
            this.spec = Task.Mobile;
        }

        public override Product completeTask(Order order)
        {
            Product product = new Product("Mobile-product made by " + this.fullName + ".");
            return product;
        }
    }
}
