using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw_4.task_4
{
    class President : Worker
    {
        public President(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"President: {Name}");
        }
    }
}
