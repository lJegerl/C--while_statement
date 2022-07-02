namespace WhileStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            // TODO 1-1. Implement the method that returns sum of an arithmetic sequence terms.
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + i;
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            // TODO 1-2. Implement the method that returns sum of an arithmetic sequence terms.
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += 17 + (i * 33);
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            // TODO 1-3. Implement the method that returns sum of an arithmetic sequence terms.
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + (i * 3);
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms4(int a, int d, int n)
        {
            // TODO 1-4. Implement the method that returns sum of an arithmetic sequence terms.
            return ((2 * a) + (d * (n - 1))) * n / 2;
        }
    }
}
