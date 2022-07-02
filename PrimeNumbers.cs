namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            // TODO 5-1. Implement the method that returns true if n is a prime number; otherwise returns false.
            uint m = n;
            uint i = 0;
            if (m == 0 || m == 1)
            {
                return false;
            }

            for (i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            // TODO 5-2. Implement the method that returns the latest prime number is (0, n] interval.
            uint result = 0;
            uint j = 1;
            while (j <= n)
            {
                bool prime = true;
                uint m = j / 2;
                uint i;
                if (j == 0 || j == 1)
                {
                    prime = false;
                }

                for (i = 2; i <= m; i++)
                {
                    if (j % i == 0)
                    {
                        prime = false;
                    }
                }

                if (prime == true)
                {
                    result = j;
                }

                j++;
            }

            return result;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            // TODO 5-3. Implement the method that returns the sum of the latest _count_ prime numbers is (0, n] interval.
            uint result = 0;
            uint j = n;
            while (j > 0)
            {
                bool prime = true;
                uint m = j / 2;
                uint i;
                if (j == 0 || j == 1)
                {
                    prime = false;
                }

                for (i = 2; i <= m; i++)
                {
                    if (j % i == 0)
                    {
                        prime = false;
                    }
                }

                if (prime == true)
                {
                    if (count > 0)
                    {
                        result += j;
                        count--;
                    }
                    else
                    {
                        return result;
                    }
                }

                j--;
            }

            return result;
        }
    }
}
