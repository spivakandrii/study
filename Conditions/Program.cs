// See https://aka.ms/new-console-template for more information

Console.WriteLine("How old are you?");

var ageInString = Console.ReadLine();

var isAgeParsed = int.TryParse(ageInString, out var age);

if (isAgeParsed == false)
{
    Console.WriteLine("Invalid age input.");

    return;
}

switch (age)
{
    case > 65:
        Console.WriteLine("You are very old!");
        break;
    case > 18:
        Console.WriteLine("You are an adult.");
        break;
    case > 7:
        Console.WriteLine("You are a child.");
        break;
    default:
        Console.WriteLine("You are a baby.");
        break;
}

return;

if (age > 65)
{
    Console.WriteLine("You are very old!");
}
else if (age > 18)
{
    Console.WriteLine("You are an adult.");
}
else if (age > 7)
{
    Console.WriteLine("You are a child.");
}
else
{
    Console.WriteLine("You are a baby.");
}