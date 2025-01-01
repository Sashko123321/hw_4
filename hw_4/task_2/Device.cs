namespace hw_4.task_2
{
    class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Device sound: *generic sound*");
        }

        public void Show()
        {
            Console.WriteLine($"Device Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Device Description: {Description}");
        }
    }

}
