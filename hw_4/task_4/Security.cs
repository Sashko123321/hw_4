using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4.task_4
{
    class Security : Worker
    {
        public Security(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Security: {Name}");
        }
    }
}
