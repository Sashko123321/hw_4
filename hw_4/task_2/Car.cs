﻿namespace hw_4.task_2
{
    class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Car sound: *vroom vroom*");
        }
    }
}
