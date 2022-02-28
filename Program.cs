using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    public enum Task
    {
        Desktop,
        Mobile,
        Web
    }

    class Program
    {

        static void Main(string[] args)
        {
            Task web = Task.Web;
            Task mobile = Task.Mobile;
            Task desktop = Task.Desktop;

            Order order1 = null;
            List<Task> tasks = new List<Task>() { web };

            List<Task> tasks2 = new List<Task>() { mobile };
            tasks2.Add(desktop);
            Order order2 = new Order("ORDER №2", 5, tasks2);
            //order2.addTask(mobile);
            //order2.addTask(desktop);

            EmployeeMobile emplMobile1 = new EmployeeMobile("Rowena Madden", 3, 1);
            EmployeeMobile emplMobile2 = new EmployeeMobile("Joss Soto", 5, 11);
            EmployeeMobile emplMobile3 = new EmployeeMobile("Sade Brock", 7, 3);
            EmployeeMobile emplMobile4 = new EmployeeMobile("Tiya Brady", 3, 4);
            EmployeeDesktop emplDesktop1 = new EmployeeDesktop("Beverly Steadman", 4);
            EmployeeDesktop emplDesktop2 = new EmployeeDesktop("Dixie Milne", 3, 7);
            EmployeeDesktop emplDesktop3 = new EmployeeDesktop("Douglas Carey", 6, 1);

            DepartmentMobile depMobile = new DepartmentMobile();
            depMobile.createDepartment("MOBILE DEPARTMENT");
            DepartmentDesktop depDesktop = new DepartmentDesktop();
            depDesktop.createDepartment("DESKTOP DEPARTMENT");

            Company company = new Company("IT-corp", depMobile);
            company.addDepartment(depDesktop);
            company.addEmployee(emplMobile1);
            company.addEmployee(emplMobile2);
            company.addEmployee(emplMobile3);
            company.addEmployee(emplMobile4);
            company.addEmployee(emplDesktop1);
            company.addEmployee(emplDesktop2);
            company.addEmployee(emplDesktop3);

            company.addOrder(order1);
            company.addOrder(order2);
            Product result = company.completeOrder();
            Console.WriteLine(result.name);

            Console.ReadLine();
        }
    }
}
