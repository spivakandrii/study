using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Animal : IAnimal
    {
        protected int CountOfPaws;

        public abstract void MakeSound();
    }
}
