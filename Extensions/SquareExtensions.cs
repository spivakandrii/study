namespace Extensions
{
    internal static class SquareExtensions
    {
        public static House Double(this House square, params int[] multipliers)
        {
            foreach (var multiplier in multipliers)
            {
                square.Square *= multiplier;
            }

            return square;
        }
    }
}
