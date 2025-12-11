namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
           {
               new Car { Id = 1, Name = "Toyota", Year = 2025 },
               new Car { Id = 2, Name = "Honda", Year = 2015 },
               new Car { Id = 3, Name = "Ford", Year = 2025 },
               new Car { Id = 4, Name = "Chevrolet", Year = 2020 },
               new Car { Id = 5, Name = "Land rover", Year = 2020 },
               new Car { Id = 6, Name = "Jaguar", Year = 2025},
               new Car { Id = 7, Name = "Moskvich", Year = 2025}
           };

            Console.WriteLine($"**********ALL CARS**********");
            Print(cars);

            //Filtering cars made after 2012
            var newCars = cars.Where(x => x.Year > 2012).ToList();
            Console.WriteLine($"**********NEW CARS**********");
            Print(newCars);

            //Sorting cars by Year
            var sortedCars = cars.OrderBy(x => x.Year).ToList();
            Console.WriteLine($"**********SORTED CARS**********");
            Print(sortedCars);

            //Sorting cars by Year by descending
            var sortedCarsByDescending = cars.OrderByDescending(x => x.Year).ToList();
            Console.WriteLine($"**********SORTED CARS DESCENDING**********");
            Print(sortedCarsByDescending);

            //Sorting cars by Name
            var sortedCarsByName = cars.OrderBy(x => x.Name).ToList();
            Console.WriteLine($"**********SORTED BY NAME CARS**********");
            Print(sortedCarsByName);

            //Sorting cars by Name by descending
            var sortedCarsByNameDescending = cars.OrderByDescending(x => x.Name).ToList();
            Console.WriteLine($"**********SORTED BY NAME CARS DESCENDING**********");
            Print(sortedCarsByNameDescending);

            IEnumerable<IGrouping<int, Car>> groupedCars = cars.GroupBy(x => x.Year);

            foreach (IGrouping<int, Car> carGroup in groupedCars)
            {
                foreach (var car in carGroup)
                {
                    Console.WriteLine($"Car name - {car.Name}, Year (group) - {car.Year}");
                }
            }

            Console.WriteLine();

            //Using anonymous method
            newCars = cars.Where(delegate (Car car)
            {
                return car.Year < 2025;
            }).ToList();

            //Using named method
            newCars = cars.Where(Predicate).ToList();

            //Take
            var first2Cars = cars.Take(2).ToList();
            Console.WriteLine($"**********FIRST 2 CARS**********");
            Print(first2Cars);

            //Take with Skip
            var second2Cars = cars.Skip(2).Take(2).ToList();
            Console.WriteLine($"**********SECOND 2 CARS**********");
            Print(second2Cars);

            //Take 1 first element from the list
            Console.WriteLine($"**********TAKE 1 ELEMENT FROM THE LIST**********");
            var firstCar = cars.First();
            Print(firstCar);

            Console.WriteLine();

            //Take 1 first element with condition from the list
            Console.WriteLine($"**********TAKE 1 ELEMENT WITH CONDITION FROM THE LIST**********");
            var firstCarWithCondition = cars.First(_ => _.Year == 2020);
            Print(firstCarWithCondition);

            Console.WriteLine();

            //Take 1 first element with wrong condition
            Console.WriteLine($"**********TAKE 1 ELEMENT WITH WRONG CONDITION**********");
            //Throws exeption
            //var noCar = cars.First(x => x.Year > 2026);
            var noCar = cars.FirstOrDefault(x => x.Year > 2026);
            Print(noCar);

            Console.WriteLine();

            //Take 1 last element with condition from the list
            Console.WriteLine($"**********TAKE 1 ELEMENT WITH CONDITION FROM THE LIST**********");
            var firstLastCarWithCondition = cars.Last(_ => _.Year == 2020);
            Print(firstLastCarWithCondition);

            Console.WriteLine();

            //Any
            //var result = cars.Any(x => x.Year == 2015);

            //Select
            var names = cars
                .Where(_ => _.Year == 2025)
                .OrderByDescending(_ => _.Name)
                .Select(_ => _.Name);
            foreach (var name in names)
            {
                Console.WriteLine($"Car name - {name}");
            }
        }

        private static bool Predicate(Car car)
        {
            return car.Year < 2025;
        }

        private static void Print(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Print(car);
            }

            Console.WriteLine();
        }

        private static void Print(Car car)
        {
            //if (car == null)
            //{
            //    Console.WriteLine("Car is null");
            //    return;
            //}

            Console.WriteLine($"Car Id - {car?.Id}, Car name - {car?.Name}, Year - {car?.Year}");
        }
    }
}