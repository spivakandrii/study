var students = new List<string>();

while (true)
{
    Menu();

    var menuNumber = GetNumber();

    MakeChoice(menuNumber);
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Add a student");
    Console.WriteLine("2. Edit a student");
    Console.WriteLine("3. Delete a student");
    Console.WriteLine("4. List of students");
    Console.WriteLine("5. Exit\n");
}

int GetNumber()
{
    int number = 0;

    while (true)
    {
        Console.WriteLine("Enter choice: \n");

        var numberString = Console.ReadLine();

        try
        {
            number = int.Parse(numberString);
        }
        catch
        {
            Console.WriteLine("Enter valid number");
        }

        if (number > 0)
        {
            break;
        }
    }

    return number;
}

void MakeChoice(int number)
{
    Console.Clear();

    switch (number)
    {
        case 1:
        {
            AddStudent();

            break;
        }
        case 2:
        {
            EditStudent();

            break;
        }
        case 3:
        {
            var name = EnterStudentName();
            students.Remove(name);

            break;
        }
        case 4:
        {
            StudentsList();

            break;
        }

        case 5:
        {
            // Ця команда повністю зупиняє виконання програми
            Environment.Exit(0);
            break;
        }
    }
}

void AddStudent()
{
    string name = EnterStudentName();

    if (students.IndexOf(name) != -1)
    {
        Console.WriteLine("Student already in list");

        Console.WriteLine("Press any key to continue...");

        Console.ReadKey();

        return;
    }

    students.Add(name);
}

void EditStudent()
{
    var name = EnterStudentName();
    var indexOfStudent = students.IndexOf(name);

    name = EnterStudentName();
    students[indexOfStudent] = name;
}

string EnterStudentName()
{
    Console.Write("Enter name: \n");
    var name = Console.ReadLine();
    return name;
}

void StudentsList()
{
    Console.WriteLine("List of students:");

    foreach (var student in students)
    {
        Console.WriteLine("Student name: " + student);
    }

    Console.WriteLine();

    Console.WriteLine("Press any key to continue...");

    Console.ReadKey();
}