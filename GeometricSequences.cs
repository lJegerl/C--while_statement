﻿namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            // TODO 3-1. Implement the method that returns sum of a geometric sequence terms.
            uint sum = 0;
            uint i = 0;
            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            // TODO 3-2. Implement the method that returns sum of a geometric sequence terms.
            uint sum = 0;
            double i = 0;
            while (i < n)
            {
                double vIn = Math.Pow(3, i);
                uint vOut = Convert.ToUInt32(vIn);
                sum += 13 * vOut;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            // TODO 3-3. Implement the method that returns count of a geometric sequence terms.
            uint sum = a;
            uint i = 1;
            if (maxTerm < a)
            {
                return 0;
            }

            while (a * r <= maxTerm)
            {
                a *= r;
                sum += a;
                i++;
            }

            return i;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            // TODO 3-4. Implement the method that returns count of a geometric sequence terms.
            uint i = 0;
            while (n > 0)
            {
                if (a >= minTerm)
                {
                    i++;
                }

                a *= r;
                n--;
            }

            return i;
        }
    }
}
