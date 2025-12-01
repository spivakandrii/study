using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Bird : Animal
    {
        private bool hasWings = true;

        public Bird(int countOfPaws)
        {
            CountOfPaws = countOfPaws;

            Console.WriteLine($"Кількість лап у пташки: {CountOfPaws}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chirp chirp");
        }
    }
}
