using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    enum TaskDepartment
    {
        Development,
        SystemAnalyst,
        Chief
    }
    class Company
    {
        public string Name { get; set; }
        public Worker Suoervisor { get; set; }
        public Worker Executor { get; set; }
        public TaskDepartment Type { get; set; }

        public Company(string name, Worker supervisor, Worker executor, TaskDepartment type)
        {
            Name = name;
            Suoervisor = supervisor;
            Executor = executor;
            Type = type;
        }
    }

}
