namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var myClassInstance = new MyFirstClass();

            myClassInstance.MyFirstProperty = "Hello, World!";

            Console.WriteLine($"Значення публічної змінної = {myClassInstance.MyFirstProperty}");

            var valueOfHiddenVariable = myClassInstance.GetHiddenVariable();

            Console.WriteLine($"Значення приатної змінної = {valueOfHiddenVariable}");

            //неможливо створити екземпляр абстрактного класу
            //var animal = new Animal();

            var dog = new Dog(4);

            var cat = new Cat(4);

            var bird = new Bird(2);

            var animalList = new List<IAnimal>();

            animalList.Add(dog);
            animalList.Add(cat);
            animalList.Add(bird);

            foreach (var animal in animalList)
            {
                animal.MakeSound();
            }
        }
    }

    public class MyFirstClass
    {
        public string MyFirstProperty;

        //private по замовчюванню
        string HiddenVariable;

        //Конструктор по замовчюванню
        public MyFirstClass()
        {
            Console.WriteLine("Виклик конструктора по замовчуванню");

            HiddenVariable = "Hidden Value";
        }

        //Публічний метод для доступу до прихованої змінної
        public string GetHiddenVariable()
        {
            return HiddenVariable;
        }
    }
}