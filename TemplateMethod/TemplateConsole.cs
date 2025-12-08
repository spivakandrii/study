using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class TemplateConsole
    {
        public static T Read<T>()
        {
            while (true)
            {
                Console.Write("Enter your value: ");

                var input = Console.ReadLine();

                try
                {
                    var newTypeVar = Convert.ChangeType(input, typeof(T));

                    Console.WriteLine($"Our new type: {newTypeVar}. Type is {newTypeVar.GetType()}");

                    return (T)newTypeVar;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
