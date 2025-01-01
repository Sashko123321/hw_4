using hw_4.task_1;
using hw_4.task_2;
using hw_4.task_3;
using hw_4.task_4;
namespace hw_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Money money = new Money(150, 75);

            Product product = new Product("Laptop", 200, 50);
            product.DisplayProduct();

            product.ReducePrice(50, 80);
            product.DisplayProduct();


            //2
            Device teapot = new Teapot("Electric Teapot", "1.5L, 2000W");
            Device microwave = new Microwave("Samsung Microwave", "800W, 20L");
            Device car = new Car("Tesla Model 3", "Electric, 300 miles range");
            Device steamship = new Steamship("Titanic", "4 engines, 52,000 tons");

            Device[] devices = new Device[] { teapot, microwave, car, steamship };

            for (int i = 0; i < devices.Length; i++)
            {
                devices[i].Show();
                devices[i].Desc();
                devices[i].Sound();
                Console.WriteLine();
            }

            //3
            MusicalInstrument violin = new Violin();
            MusicalInstrument trombone = new Trombone();
            MusicalInstrument ukulele = new Ukulele();
            MusicalInstrument cello = new Cello();

            MusicalInstrument[] instruments = new MusicalInstrument[] { violin, trombone, ukulele, cello };

            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i].Show();
                instruments[i].Sound();
                instruments[i].Desc();
                instruments[i].History();
                Console.WriteLine();
            }

            //4
            Worker president = new President("Sasha");
            Worker security = new Security("Max");
            Worker manager = new Manager("Oleg");
            Worker engineer = new Engineer("Petro");

            Worker[] workers = { president, security, manager, engineer };

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
            }

        }
    }

}
