using System;

class Program

{

    static void Main(string[] args)

    {

        Console.Write("Введiть перше слово: ");

        string word1 = Console.ReadLine().ToLower();

        Console.Write("Введiть друге слово: ");

        string word2 = Console.ReadLine().ToLower();

        bool wordsequal = true;

        foreach (char letter in word2)

        {

            int index = word1.IndexOf(letter);

            if (index == -1)

            {

                wordsequal = false;

                break;

            }

            word1 = word1.Remove(index, 1);

        }

        if (wordsequal)

        {

            Console.WriteLine("З першого слова можна скласти друге");

        }

        else { Console.WriteLine("З першого слова не можна скласти друге"); }

        Console.ReadLine();

    }

}