using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbersList
{
    public class PrimeNumbers
    {
        public int GetDemPriiiimes(int a)
        {
            List<int> PrimeList = new List<int>();

            for (int i = 1; i <= 105000; i++)
            {
                if (i == 2)
                    PrimeList.Add(i);
                if (i == 3)
                    PrimeList.Add(i);
                if (i > 3)
                {
                    bool isPrime = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime == true)
                        PrimeList.Add(i);
                }
            }
            return PrimeList[a - 1];
        }
    }
}

