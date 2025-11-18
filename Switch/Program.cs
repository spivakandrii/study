// See https://aka.ms/new-console-template for more information

//switch with numbers

Console.WriteLine("Please enter your age\n");
 
var inputString = Console.ReadLine();

var age = int.Parse(inputString);

switch (age)
{
    case 1:
        Console.WriteLine("you are very young!");
        break;
    case 65:
        Console.WriteLine("you are very old!");
        break;
    default:
        Console.WriteLine("i don't know what to say");
        break;
}

//switch with strings
/*
 Console.WriteLine("Please enter animal name\n");
 
var input = Console.ReadLine();

switch (input)
{
    case "frog":
        Console.WriteLine("Kva kva");
        break;
    case "dog":
    case "spitz":
    case "bulldog":
    {
        Console.WriteLine("waff");
        break;
    }
    case "cat":
        Console.WriteLine("meow");
        break;
    default:
        Console.WriteLine("animal not detected");
        break;
}*/

//example with dates
// Console.WriteLine("Please enter your birthday\n");
//  
// var inputString = Console.ReadLine();
//
// var date = DateTime.ParseExact(inputString, "dd-MM-yyyy", null);
//
// Console.WriteLine(date);