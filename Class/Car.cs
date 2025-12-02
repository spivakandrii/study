namespace Class
{
    internal class Car
    {
        public Car()
        {
            Count++;
        }

        public Car(int power, string model, int age)
        {
            Console.WriteLine("Hello. I am constructor");

            _power = power;
            _model = model;
            Year = age;

            Count++;
        }

        //Статична властивість
        public static int Count { get; set; }

        private int _power ;

        public int GetPower()
        {
            return _power;
        }

        public void SetPower(int power)
        {
            _power = power;
        }
        
        private string _model;

        public string Model
        {
            get
            {
                return "My car is " + _model;
            }

            set
            {
                if (value.Contains("BMW"))
                {
                    _model = value + " M Series";
                }
                else
                {
                    _model = value;
                }
            }
        }

        public int Year { get; set; }

        public void Print()
        {
            Console.WriteLine($"My car is {_model}. Power of my car is {_power} hp. Year of manufacture {Year}");
        }
    }
}
