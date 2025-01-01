namespace hw_4.task_1
{
    class Product : Money
    {
        private string _name;

        public Product(string productName, int whole, int fractional) : base(whole, fractional)
        {
            _name = productName;
        }

        public void ReducePrice(int whole, int fractional)
        {
            int currentWhole = GetWholePart();
            int currentFractional = GetFractionalPart();

            int totalCurrentCents = currentWhole * 100 + currentFractional;
            int totalReductionCents = whole * 100 + fractional;

            int newTotalCents = totalCurrentCents - totalReductionCents;

            if (newTotalCents < 0)
            {
                newTotalCents = 0;
            }
            SetMoney(newTotalCents / 100, newTotalCents % 100);
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {_name}");
            Display();
        }
    }
}
