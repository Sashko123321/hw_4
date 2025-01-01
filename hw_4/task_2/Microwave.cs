namespace hw_4.task_2
{
    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound: *beep beep beep*");
        }
    }
}
