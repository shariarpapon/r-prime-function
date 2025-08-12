using System;

public static class RPrimeFunction
{
    static int[] primes;
    static int[] primePartialProducts;

    static void Main()
    {
        int roInput = 150000;
        int reInput = 150000;
        int largerInput = (reInput >= roInput ? reInput : roInput) + 1;

        primes = GeneratePrimes(largerInput);
        primePartialProducts = GeneratePrimePartialProducts(largerInput, primes);

        Console.WriteLine($"Ro({roInput}) = {R_O(roInput)}");
        Console.WriteLine($"Re({reInput}) = {R_E(reInput)}");
    }

    static double R_O(int n)
    {
        double r = 0.0;
        double product = 1.0;
        for (int i = 0; i < n; i++)
        {
            product *= primes[i];
            r += 1.0 / product;
        }

        return 1 + r;
    }

    static double Q(int x) => (double)primePartialProducts[x];

    static double R_E(int k)
    {
        double q_k = Q(k);
        double s = 0;
        for (int n = 1; n <= k; n++)
        {
            s += q_k / Q(k - n);
        }
        return ((double)1 / q_k) * (1 + q_k + s);
    }

    static int[] GeneratePrimePartialProducts(int x, int[] primes)
    {
        int p = 1;
        int[] partialProducts = new int[x];
        for (int i = 0; i < x; i++)
        {
            p *= primes[i];
            partialProducts[i] = p;
        }
        return partialProducts;
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