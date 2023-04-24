using System;

class Program

{

    static void Main(string[] args)

    {

        Console.Write("Введiть перше число: ");

        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть друге число: ");

        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть третє число: ");

        int num3 = Convert.ToInt32(Console.ReadLine());

        Countchecker(num1, num2, num3);

        Console.ReadLine();

    }

    static int Maxones(int num)

    {

        int count = 0;

        while (num > 0)

        {

            if (num % 2 == 1)

            {

                count++;

            }

            num /= 2;

        }

        return count;

    }

    static void Countchecker(int num1, int num2, int num3)

    {

        if (Maxones(num1) >= Maxones(num2) && Maxones(num1) >= Maxones(num3))

        {

            Console.WriteLine($"{num1} має найбiльшу кількiсть одиниць у своєму записi");

        }

        else if (Maxones(num2) >= Maxones(num1) && Maxones(num2) >= Maxones(num3))

        {

            Console.WriteLine($"{num2} має найбiльшу кількiсть одиниць у своєму записi");

        }

        else

        {

            Console.WriteLine($"{num3} має найбiльшу кiлькiсть одиниць у своєму записi");

        }

    }

}