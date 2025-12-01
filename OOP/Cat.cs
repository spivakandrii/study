using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Cat : Animal
    {
        public Cat(int countOfPaws)
        {
            CountOfPaws = countOfPaws;

            Console.WriteLine($"Кількість лап у котика: {CountOfPaws}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
