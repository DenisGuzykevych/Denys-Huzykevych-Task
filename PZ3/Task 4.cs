using System;

class Program

{

    static int NSD(int a, int b)

    {

        if (b == 0)

        {

            return a;

        }

        else

        {

            return NSD(b, a % b);

        }

    }

    static void Main(string[] args)

    {

        Console.Write("Введiть кiлькiсть чисел: ");

        int k = Convert.ToInt32((Console.ReadLine()));

        int[] a = new int[k];

        for (int i = 0; i < k; i++)

        {

            Console.Write($"Введiть число {i + 1}: ");

            a[i] = Convert.ToInt32((Console.ReadLine()));

        }

        int count = a[0];

        for (int i = 1; i < k; i++)

        {

            count = NSD(count, a[i]);

        }

        Console.WriteLine($"НСД {a.Length} чисел: {count}");

        Console.ReadLine();

    }

}