namespace Funtions
{
    class Program
    {
        static void Main(string[] args)
        {
            //function to clean console
            Console.Clear();

            //Output();

            //Output();

            MultiplyAndOutput(5, 10);

            int area = Multiply(7, 3);

            Output(area);

            Output(1, 2);

            var (x, y) = ReturnCoordinates();

            Output(x, y);
        }

        static void Output(int value)
        {
            Console.WriteLine($"My value is: {value}");
        }

        static void Output(int value1, int value2)
        {
            Console.WriteLine($"My value1 is: {value1}, My value2 is: {value2},");
        }

        static void MultiplyAndOutput(int width, int height)
        {
            var area = width * height;

            Console.WriteLine($"Area: {area}");
        }

        static int Multiply(int width, int height)
        {
            var area = width * height;

            return area;
        }

        static (int x, int y) ReturnCoordinates()
        {
            var x = 10;

            var y = 20;

            return (x, y);
        }
    }
}

