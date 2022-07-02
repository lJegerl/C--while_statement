namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            // TODO 2-1. Implement the method that returns sum of an quadratic sequence terms.
            long sum = 0, term = 0;
            long i = 1;
            while (term <= maxTerm)
            {
                term = (a * i * i) + (b * i) + c;
                if (term <= maxTerm)
                {
                    sum += term;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            // TODO 2-2. Implement the method that returns sum of an quadratic sequence terms.
            long sum = 0, i = 0, j = 0;
            j = startN;
            while (i < count)
            {
                sum += (a * j * j) + (b * j) + c;
                i++;
                j++;
            }

            return sum;
        }
    }
}
