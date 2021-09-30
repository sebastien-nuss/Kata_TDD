using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactorGenerator
    {
        public List<int> Generate(int v)
        {
            List<int> primes = new List<int>();

            for (int factor = 2; v > 1; factor++)
            {
                for (; v % factor == 0; v /= factor)
                    primes.Add(factor);
            }

            return primes;
        }
    }
}