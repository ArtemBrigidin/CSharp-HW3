using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker;

namespace ConsoleApp3
{
    public class Manager : Workerr
    {
        public string Department { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Manager: {Name}, Department: {Department}");
        }
    }
}
