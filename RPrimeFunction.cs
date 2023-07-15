using System;

public static class RPrimeFunction
{
    static void PrintOutput(int n)
    {
        double r = CalculateRPrime(n);
        Console.WriteLine($"The value of RPrime for n = {n} is approximately: {r}");
    }

    static double CalculateRPrime(int n)
    {
        double r = 0.0;
        int[] primes = GeneratePrimes(n);

        double product = 1.0;
        for (int i = 0; i < n; i++)
        {
            product *= primes[i];
            r += 1.0 / product;
        }

        return 1 + r;
    }

    // Method to generate the first 'n' prime numbers
    static int[] GeneratePrimes(int n)
    {
        int[] primes = new int[n];
        primes[0] = 2;
        int count = 1;
        int num = 3;

        while (count < n)
        {
            if (IsPrime(num))
            {
                primes[count] = num;
                count++;
            }

            num += 2; // Increment by 2 to check odd numbers only
        }

        return primes;
    }

    // Method to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}