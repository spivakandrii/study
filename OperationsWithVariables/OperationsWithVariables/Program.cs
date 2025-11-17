// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string firstName = "Andrii";

string lastName = "Jones";

var name = firstName + lastName;

Console.WriteLine("my name is: " + name);

int width = 50;
int height = 70;

int length = width + height;
var diff = height - width;
var multiply = height * width;
var division = height / width;
//var vidideOnZero = height / 0;

Console.WriteLine("length is: " + length);
Console.WriteLine("diff is: " + diff);
Console.WriteLine("multiply: " + multiply);
Console.WriteLine("multiply: " + division);

var hasKey = true;
var hasPasswrod = false;

//var canLogin = hasKey && hasPasswrod;

var canEnter = hasKey || hasPasswrod;

var text = "Stepan can enter the door: " + canEnter;

Console.WriteLine(text);

int igorsAge = 44;
decimal andriisAge = 39.3M;

// var ageInTotal = igorsAge + andriisAge;
// Console.WriteLine("Our age in total=" + ageInTotal);
// Console.WriteLine("ype of new variable=" + ageInTotal.GetType());

var ageInTotal = igorsAge + (int)andriisAge;
Console.WriteLine("Our age in total=" + ageInTotal);
Console.WriteLine("Type of new variable=" + ageInTotal.GetType());

var myAgeInString = Console.ReadLine();
Console.WriteLine($"my age={myAgeInString}, type of variable is {myAgeInString.GetType()}");

// var myAgeInInt = int.Parse(myAgeInString);
// Console.WriteLine($"my age={myAgeInInt}, type of variable is {myAgeInInt.GetType()}");

double myAgeInInt = Convert.ToInt32(myAgeInString);
Console.WriteLine($"my age={myAgeInInt}, type of variable is {myAgeInInt.GetType()}");


