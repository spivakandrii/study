namespace Params
{
    internal class Print
    {
        public void Run(decimal? sum = null)
        {
            Console.WriteLine($"Sum - {sum}");
        }

        public void Run(int count, string arg = "menu")
        {
            Console.WriteLine($"Arg - {arg}, count - {count}");
        }

        public void Run(params string [] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine($"Arg - {arg}");
            }
        }
    }
}
