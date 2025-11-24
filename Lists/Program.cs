//////////////////////////////////////List

Console.WriteLine("-------LIST-------");

var students = new List<string> { "Alice", "Bob", "Charlie", "Diana", "Diana" };

foreach (var student in students)
{
    Console.WriteLine($"Student Name: {student}");

    if (student == "Bob")
    {
        break;
    }
}

Console.WriteLine();

students.Add("Stepan");

for (int i = 0; i < students.Count; i++)
{
    if (students[i] == "Bob")
    {
        continue;
    }

    Console.WriteLine($"Student {i + 1}: {students[i]}");
}

Console.WriteLine();

students.Remove("Charlie");

foreach (var student in students)
{
    Console.WriteLine($"Remaining Student: {student}");
}

Console.WriteLine();

var newStudents = students.ToHashSet();

foreach (var student in newStudents)
{
    Console.WriteLine($"New Student from HashSet: {student}");
}

/////////////////////////////////////HashSet

Console.WriteLine("-------HashSet-------");

var teachers = new HashSet<string> { "Alice Lennon", "Bob Marley", "Charlie Kirk", "Princess Diana", "Princess Diana" };

foreach (var teacher in teachers)
{
    Console.WriteLine($"Teacher Name: {teacher}");
}

var wasAdded = teachers.Add("Elon Musk");

Console.WriteLine($"\nWas Elon Musk added? {wasAdded}");

wasAdded = teachers.Add("Bob Marley");

Console.WriteLine($"Was Bob Marley added again? {wasAdded}");