using Nullable;

int? number = 1;

Nullable<int> nullableNumber = 5;

Console.WriteLine($"int? number {number.GetType()} is a primitive data type: {number.GetType().IsPrimitive}.");

Console.WriteLine($"Nullable<int> {nullableNumber.GetType()} is a primitive data type: {nullableNumber.GetType().IsPrimitive}.");

Console.WriteLine("int? {0} is a primitive data type: {1}.", typeof(int?).Name, typeof(int?).IsPrimitive);

Console.WriteLine("int? {0} is a reference data type: {1}.", typeof(int?).Name, !(typeof(int?).IsValueType));

var ukraine = new Country("Ukraine", 52000000, new DateTime(1991, 08, 24), DateTime.UtcNow);

ukraine.Print();

ukraine.Update(49000000);

ukraine.Print();

// Console.WriteLine(default(int));
// Console.WriteLine(default(DateTime));
// Console.WriteLine(default(decimal));
// Console.WriteLine(decimal.MaxValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine(float.MaxValue);
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(long.MaxValue);
// Console.WriteLine(DateTime.MaxValue);