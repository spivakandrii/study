using TemplateMethod;

///////////////// Datetime

//var templateRepositoryDatetime = new TemplateRepository<DateTime>();

//templateRepositoryDatetime.Add(TemplateConsole.Read<DateTime>());

//templateRepositoryDatetime.Add(TemplateConsole.Read<DateTime>());

//templateRepositoryDatetime.Add(TemplateConsole.Read<DateTime>());

//templateRepositoryDatetime.Add(TemplateConsole.Read<DateTime>());

//templateRepositoryDatetime.Add(TemplateConsole.Read<DateTime>());

//var datetimeItems = templateRepositoryDatetime.GetAll();

//foreach (var item in datetimeItems)
//{
//    Console.WriteLine(item);
//}

///////////////// Strings

//var templateRepositoryString = new TemplateRepository<string>();

//templateRepositoryString.Add("first text");

//templateRepositoryString.Add("second text");

//foreach (var textValue in templateRepositoryString.GetAll())
//{
//    Console.WriteLine(textValue);
//}

var templateRepositoryAnimal = new TemplateRepository<Animal>();

templateRepositoryAnimal.Add(new Animal("Dog", 5));

templateRepositoryAnimal.Add(new Animal("Cat", 7));

foreach (var animal in templateRepositoryAnimal.GetAll())
{
    Console.WriteLine($"Our animal name {animal.Name}, age {animal.Age}");
}


//var decimalFromConsole = TemplateConsole.Read<decimal>();

//var integerFromConsole = TemplateConsole.Read<int>();

//var stringFromConsole = TemplateConsole.Read<string>();