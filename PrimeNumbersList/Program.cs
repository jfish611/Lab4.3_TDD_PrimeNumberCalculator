using System;

namespace PrimeNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to nth prime.");
            while (true)
            {
                Console.WriteLine("Now which number prime would you like to see?");
                int.TryParse(Console.ReadLine(), out int userChoice);

                PrimeNumbers abc = new PrimeNumbers();
                Console.WriteLine($"You selected the prime at number {userChoice} of the list of primes. \n That number is {abc.GetDemPriiiimes(userChoice)}");
            }
        }
    }
}
