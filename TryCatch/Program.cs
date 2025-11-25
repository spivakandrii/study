Console.WriteLine("Please enter number!");

var numberString = Console.ReadLine();

int number = 0;

try
{
    number = ParseNumber(numberString);
}
catch
{
    Console.WriteLine("Our first error. Please enter Again");

    numberString = Console.ReadLine();

    number = ParseNumber(numberString);
}
finally
{
    Console.WriteLine($"Our number is {number}");
}

int ParseNumber(string stringNumber)
{
    return int.Parse(stringNumber);
}