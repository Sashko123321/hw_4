using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4.task_3
{
    class Violin : MusicalInstrument
    {
        public Violin() : base("Violin") { }

        public override void Sound()
        {
            Console.WriteLine("Violin sound...");
        }
        public override void Desc()
        {
            Console.WriteLine("Violin desc: A violin is a stringed musical instrument");
        }
        public override void History()
        {
            Console.WriteLine("Violin history: The violin in its present form emerged in early 16th-century northern Italy");
        }

    }
}
