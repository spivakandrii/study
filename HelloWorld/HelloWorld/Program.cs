using System.Text;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = Encoding.UTF8;

// variables

//integer variable initialization
int age;

//variable assignment
age = 39;

//string
string name = "Андрій";

//boolean
bool liveInUkraine = false;

//float
float height = 1.79f;

//double
double weight = 80.5;

//char
char firstLetterOfName = 'А';

//decimal
decimal bankBalance = 10500.75m;

int ageOfFriend = 38;

Console.WriteLine("My name is " + name);

var eyeColor = "grey";

Console.WriteLine("My color of eyes is " + eyeColor);

// variable declaration and not initialized - cause error if used
//var ciry;
//Console.WriteLine(ciry);

//constant
const double pi = 3.14159;

string firstName = "Іван", lastName = "Петренко";

//old style string formatting
Console.WriteLine(string.Format("Мій ріст={0}, моя вага={1}", height, weight));

//interpolated strings
Console.WriteLine($"Мій ріст={height}, моя вага={weight}");