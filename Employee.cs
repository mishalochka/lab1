using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    public abstract class Employee
    {
        public string fullName { get; set; }
        public Task spec { get; protected set; }
        public int time { get; set; } 
        public int complOrders { get; set; }

        protected Employee(string _fullName, int _time, int _complOrders = 0)
        {
            this.fullName = _fullName;
            time = _time;
            complOrders = _complOrders;
        } 

        public abstract Product completeTask(Order order); //выполнить задачу

        public bool isAbleToComplete(Order order) //проверить возможность выполнить задачу
        {
            return (this.time <= order.time);
        }
    }
}
