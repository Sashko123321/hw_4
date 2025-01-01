using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4.task_3
{
    class Trombone: MusicalInstrument
    {
        public Trombone() : base("Trombone") { }

        public override void Sound()
        {
            Console.WriteLine("Trombone sound...");
        }
        public override void Desc()
        {
            Console.WriteLine("Trombone desc: ...");
        }
        public override void History()
        {
            Console.WriteLine("Trombone history: ...");
        }
    }
}
