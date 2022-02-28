using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    class EmployeeDesktop: Employee
    {
        public EmployeeDesktop(string _fullName, int _time, int _complOrders = 0): base (_fullName, _time, _complOrders)
        {
            this.spec = Task.Desktop;
        }

        public override Product completeTask(Order order)
        {
            Product product = new Product("Desktop-product made by " + this.fullName + ".");
            return product;
        }
    }
}
