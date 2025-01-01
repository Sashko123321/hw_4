using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4.task_3
{
    class Cello : MusicalInstrument
    {
        public Cello() : base("Cello") { }

        public override void Sound()
        {
            Console.WriteLine("Cello sound...");
        }
        public override void Desc()
        {
            Console.WriteLine("Cello desc: ...");
        }
        public override void History()
        {
            Console.WriteLine("VCelloolin history: ...");
        }
    }
}
