using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class PrimeGenerator
    {
        public delegate void Message(List<int> primes);
        public event Message PrimeGenerationComplete;

        private List<int> _primes;
        public void Generate(int range)
        {
            _primes = new List<int>();

            for(int i = 2; i < range; i++)
            {
                if(IsPrime(i))
                {
                    _primes.Add(i);
                }
            }

            if(PrimeGenerationComplete != null)
                PrimeGenerationComplete.Invoke(_primes);
        }

        public List<int> GetPrimes()
        {
            return _primes;
        }

        private bool IsPrime(int number)
        {
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
