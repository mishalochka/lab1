using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    class DepartmentDesktop : Department
    {
        public DepartmentDesktop()
        {
            this.task = Task.Desktop;
        }

        public override void createDepartment(string _name) //инициализация отдела
        {
            this.name = _name;
            this.task = Task.Desktop;
        }
    }
}
