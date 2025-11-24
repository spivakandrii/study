Console.OutputEncoding  =  System.Text.Encoding.UTF8;

var dictionary = new Dictionary<int, int>();

dictionary.Add(1, 1);

var teachersById =  new Dictionary<int, string>();

teachersById.Add(50, "Дмитро Павлович");
teachersById.Add(60, "Степан Миколайович");

foreach (var item in teachersById)
{
    Console.WriteLine($"Age {item.Key} - Name {item.Value}");
}

Console.WriteLine($"Викладач з віком 50 - {teachersById[50]}");

//Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: 50
//teachersById.Add(50, "Дмитро Павлович");

var added = teachersById.TryAdd(50, "Дмитро Павлович");
Console.WriteLine($"Дмитро Павлович додався? {added}");
if (!added)
{
    added = teachersById.TryAdd(40, "Дмитро Павлович");
    Console.WriteLine($"Дмитро Павлович додався? {added}");
}

var teacher = teachersById[50];
Console.WriteLine($"Teacher by key 50 {teacher}");

//Unhandled exception. System.Collections.Generic.KeyNotFoundException: The given key '10' was not present in the dictionary.
// teacher = teachersById[10];
// Console.WriteLine($"Teacher by key 10 {teacher}");

var success = teachersById.TryGetValue(10, out var teacherWithId10);
if (success)
{
    Console.WriteLine($"Teacher by key 10 {teacherWithId10}");
}

success = teachersById.TryGetValue(40, out var teacherWithId40);
if (success)
{
    Console.WriteLine($"Teacher by key 40 {teacherWithId40}");
}


Console.WriteLine();

