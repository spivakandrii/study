namespace Nullable;

public class Country
{
    public Country(string name, int  population, DateTime independenceDay, DateTime createdDate)
    {
        Name = name;
        Population = population;
        CreatedDate = createdDate;
        IndependenceDay = independenceDay;
    }

    private string Name { get; }

    private int Population { get; set; }

    private DateTime IndependenceDay { get; }

    private DateTime CreatedDate { get; }

    private DateTime? UpdatedDate { get; set; }

    public void Update(int population)
    {
        Population = population;
        UpdatedDate =  DateTime.UtcNow;
    }
    
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Population {Population}, IndependenceDay {IndependenceDay}, CreatedDate {CreatedDate}, UpdatedDate {UpdatedDate},");
    }
}