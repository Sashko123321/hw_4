namespace hw_4.task_2
{
    class Steamship : Device
    {
        public Steamship(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Steamship sound: *hooooonk*");
        }
    }
}
