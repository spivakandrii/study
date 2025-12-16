using Extensions;

var text = "my text";

Console.WriteLine($"Before multiply {text}");

text.Multiply();

Console.WriteLine($"After multiply {text}");

//class House
var house = new House { Square = 100 };

Console.WriteLine($"Before double square {house.Square}");

house.Double(4, 5, 6);

Console.WriteLine($"After double square {house.Square}");