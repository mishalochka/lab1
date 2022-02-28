using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    public class Company
    {
        public string name { get; set; }
        public List<Department> dep { get; set; } = new List<Department>();
        public List<Order> ord { get; set; } = new List<Order>();

        public Company(string _name, List<Department> _dep)
        {
            this.name = _name;
            this.dep = _dep;
        }

        public Company(string _name, Department _dep)
        {
            this.name = _name;
            this.addDepartment(_dep);
        }


        public Product completeOrder() //выполнить заказ (первый в списке)
        {
            Order order = ord.First();
            Product result = new Product();
            foreach (Task task in order.tasks)
            {
                Department executor = dep.Find(item => item.task == task);
                Product product = executor.completeTask(order);
                result.name += (" " + product.name);
            }
            return result;
        }

        private bool isAbleToComplete(Order order) //проверить возможность выполнения заказа
        {
            foreach (Task task in order.tasks)
            {
                Department executor = dep.Find(item => item.task == task);
                if (executor == null) return false;
                if (!executor.isAbleToComplete(order)) return false;
            }
            return true;
        }

        public void addDepartment(Department department)
        {
            this.dep.Add(department);
        }

        public void addOrder(Order order)
        {
            if (order == null)
            {
               Console.WriteLine($"order can't be completed.");
                return;
            }
           if (this.isAbleToComplete(order))
           {
                    this.ord.Add(order);
            }
           else Console.WriteLine($"order {order.name} can't be completed.");
        }

        public void addEmployee(Employee employee)
        {
            foreach (Department department in dep)
            {
                if (department.task == employee.spec) department.addEmployee(employee);
            }
        }
    }
}
