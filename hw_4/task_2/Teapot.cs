namespace hw_4.task_2
{
    class Teapot : Device
    {
        public Teapot(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Teapot sound: *whistle*");
        }
    }

}
