using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    public abstract class Department
    {
        public string name { get; set; }
        public List<Employee> empl { get; set; } = new List<Employee>();
        public Task task { get; protected set; }

        public abstract void createDepartment(string _name); //инициализация отдела

        public bool isAbleToComplete(Order order) //проверка возможности выполнить заказ
        {
            foreach (Task task in order.tasks)
                if (this.task == task) return true;
            return false;
        }

        public Product completeTask(Order order) //выполнение задачи 
        {
            int min = Int32.MaxValue;
            int num = 0;
            for (int i = 0; i < this.empl.Count; i++) //поиск подходящего работника
            {
                if (this.empl[i].complOrders < min)
                {
                    min = this.empl[i].complOrders;
                    num = i;
                }
            }
            return this.empl[num].completeTask(order);
        }

        public bool isAbleToBeOnTime(Order order) //проверка, может ли отдел выполнить указанную задачу в срок
        {
            int min = Int32.MaxValue;
            int num = 0;
            for (int i = 0; i < empl.Count; i++) //поиск подходящего работника
            {
                if (empl[i].complOrders < min)
                {
                    min = empl[i].complOrders;
                    num = i;
                }
            }
            return (empl[num].time <= order.time);
        }

        public void addEmployee(Employee employee)
        {
            this.empl.Add(employee);
        }
    }
}
