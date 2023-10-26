using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Worker
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Worker Chief { get; set; }

        public Worker(string name, string department, Worker chief) 
        { 
            Name = name;
            Department = department;
            Chief = chief;
        }

    }
}
