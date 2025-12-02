namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car(200, "Mercedes Sprinter", 20);

            myCar.Print();

            var carOfMyFather = new Car();

            carOfMyFather.SetPower(70);
            carOfMyFather.Model = "Moskvich";
            carOfMyFather.Year = 50;

            carOfMyFather.Print();

            new Car();
            new Car();
            new Car();
            new Car();
            new Car();
            new Car();
            new Car();
            new Car();

            Console.WriteLine($"Count of Car class instances is {Car.Count}");

            ////////////////////////////////////Building class////////////////////////////////////
            
            Console.WriteLine();

            //Object initializer syntax
            var building = new Building
            {
                StreetName = "Lennon",
                Year = 1990
            };

            //Alternative way of setting properties
            //building.StreetName = "Lennon";
            //building.Year = 1990;

            Console.WriteLine($"Building is on {building.StreetName} street and was built in {building.Year} year.");
        }
    }
}