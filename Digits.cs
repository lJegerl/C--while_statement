namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            // TODO 4-1. Implement the method that returns sum of digits of a number.
            ulong sum = 0;
            while (n > 9)
            {
                sum += n % 10;
                n /= 10;
            }

            sum += n;
            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            // TODO 4-2. Implement the method that returns product of digits of a number.
            ulong sum = 1;
            while (n > 9)
            {
                sum *= n % 10;
                n /= 10;
            }

            sum *= n;
            return sum;
        }
    }
}
