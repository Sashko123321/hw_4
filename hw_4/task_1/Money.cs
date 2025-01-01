namespace hw_4.task_1
{
    class Money
    {
        private int _wholePart;
        private int _fractionalPart;

        public Money(int whole, int fractional)
        {
            SetMoney(whole, fractional);
        }

        public void SetMoney(int whole, int fractional)
        {
            if (fractional >= 100)
            {
                whole += fractional / 100;
                fractional %= 100;
            }

            _wholePart = whole;
            _fractionalPart = fractional;
        }

        public void Display()
        {
            Console.WriteLine("Amount: " + _wholePart + "," + (_fractionalPart < 10 ? "0" : "") + _fractionalPart);
        }

        public int GetWholePart()
        {
            return _wholePart;
        }

        public int GetFractionalPart()
        {
            return _fractionalPart;
        }
    }
}
