using System;

class Program

{

    static void Main(string[] args)

    {

        double sum = 0;

        double dosum = 0;

        int n = 0;

        do

        {

            dosum = sum;

            sum += Math.Pow(-1, n) * (1 - 2.0 * n / (2 * n + 1));

            n++;

        }

        while (Math.Abs(sum - dosum) > 0.000001);

        Console.WriteLine("Сума членiв ряду: " + sum);

        double sum10 = 0;

        for (int i = 0; i < 10; i++)

        {

            sum10 += Math.Pow(-1, i) * (1 - 2.0 * i / (2 * i + 1));

        }

        Console.WriteLine("Сума перших 10 членiв ряду: " + sum10);

        Console.ReadLine();

    }

}