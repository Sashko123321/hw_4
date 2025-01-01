using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4.task_3
{
    class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele") { }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sound...");
        }
        public override void Desc()
        {
            Console.WriteLine("Ukulele desc: ...");
        }
        public override void History()
        {
            Console.WriteLine("Ukulele history: ...");
        }
    }
}
