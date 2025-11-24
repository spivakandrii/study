// See https://aka.ms/new-console-template for more information



var numbers = new[] { 231, 234234, 3434, 777, 333 };

var days = new string[3];

days[0] = "Monday";

days[1] = "Tuesday";

days[2] = "Thursday";

for (int index = 4; index >= 0; index--)
{
    Console.WriteLine($"Number[{index}] = {numbers[index]}");
}

foreach (var day in days)
{
    Console.WriteLine($"today is {day}");
}

//Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//days[3] = "Friday";

var matrix = new int[4, 5, 3];

matrix[0, 0, 0] = 1;

var sizeI = matrix.GetLength(0);

var sizeJ = matrix.GetLength(1);

var sizeK = matrix.GetLength(2);

Random rnd = new Random();

for (int i = 0; i < sizeI; i++)
{
    for (int j = 0; j < sizeJ; j++)
    {
        for (int k = 0; k < sizeK; k++)
        {
            matrix[i, j, k] = rnd.Next(1, 1000);
        }
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for (int k = 0; k < sizeK; k++)
        {
            Console.WriteLine($"matrix[{i}, {j}, {k}] {matrix[i, j, k]}");
        }
    }
}