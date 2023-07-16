using System;

public static class RPrimeFunction
{
    static int[] primes;

    static void Main()
    {
        int n = 10000;
        primes = GeneratePrimes(n);

        double r = R_O(n);
        Console.WriteLine($"R_Original: {R_O(n)}");
        Console.WriteLine($"R_Expanded: {R_E(n)}");
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


    static double R_E(int k)
    {
        double q_k = Q(k);
        double s = 0;
        for (int n = 1; n <= k - 1; n++)
        {
            s += q_k / Q(k - n);
        }

        return ((double)1 / q_k) * (1 + q_k + s);
    }

    static int Q(int x)
    {
        int p = 1;
        for (int i = 0; i < x; i++)
        {
            p *= primes[i];
        }
        return p;
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