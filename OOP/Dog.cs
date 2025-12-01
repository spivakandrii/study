using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dog : Animal
    {
        public Dog(int countOfPaws)
        {
            CountOfPaws = countOfPaws;

            Console.WriteLine($"Кількість лап у песика: {CountOfPaws}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
