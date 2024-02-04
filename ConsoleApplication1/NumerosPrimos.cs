using System;
using System.Collections.Generic;

class Program
{
    static bool EsPrimo(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static List<int> NumerosPrimos(int hasta)
    {
        List<int> primos = new List<int>();

        for (int i = 2; i <= hasta; i++)
        {
            if (EsPrimo(i))
                primos.Add(i);
        }

        return primos;
    }

    static void Main()
    {
        int limiteSuperior = 100;
        Console.WriteLine("Números primos hasta " + limiteSuperior + ":");
        foreach (int primo in NumerosPrimos(limiteSuperior))
        {
            Console.Write(primo + " ");
        }
    }
}
