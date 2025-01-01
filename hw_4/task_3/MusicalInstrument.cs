using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4.task_3
{
    class MusicalInstrument
    {
        public string Name { get; set; }

        public MusicalInstrument(string name)
        {
            Name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Sound...");
        }
        public virtual void Show() {
            Console.WriteLine($"Name: {Name}");
        }
        public virtual void Desc() {
            Console.WriteLine("Desc instrument");
        }
        public virtual void History()
        {
            Console.WriteLine("History instrument");
        }
    }
}
