using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laba1
{
    public class Order
    {
        public string name { get; set; }
        public List<Task> tasks { get; set; } = new List<Task>();
        public int time { get; set; }

        public Order(string _name, int _time, List<Task> _tasks)
        {
            this.name = _name;
            this.time = _time;
            this.tasks = _tasks;

        }
        
        public void addTask(Task task)
        {
            this.tasks.Add(task);
        }

    }


}
