using System;


namespace PZ5
{
    class Program
    {
        [Flags]
        enum Uni
        {
            Default = 0b00000000,
            DTEU = 0b00000001,
            KPI = 0b00000010,
            KNU = 0b00000100,
            LNU = 0b00001000,
            HAR = 0b00010000,
            STAN = 0b00100000,
            MIT = 0b01000000,
            UCLA = 0b10000000
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Автор програми: Гузикевич Денис");
            Console.WriteLine("\nОберiть унiверситет: ");
            Console.WriteLine("\nУкраїнськi унiверситети:");
            Console.WriteLine("1.Державний торговельно економiчний унiверситет");
            Console.WriteLine("2.Київський полiтехнiчний iнститут");
            Console.WriteLine("3.Київський нацiональний унiверситет iменi Тараса Шевченка");
            Console.WriteLine("4.Львiвський нацiональний унiверситет iменi Iвана Франка ");
            Console.WriteLine("\nАмериканськi унiверситети:");
            Console.WriteLine("5.Гарвардський унiверситет");
            Console.WriteLine("6.Стенфордський унiверситет");
            Console.WriteLine("7.Массачусетський технологiчний iнститут");
            Console.WriteLine("8.Калiфорнiйський унiверситет в Лос-Анджелесi");

            Console.WriteLine("\nВведiть унiверситети якi ви хочете обрати через кому");

            string s = Console.ReadLine();
            string[] values = s.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                int value = Convert.ToInt32(values[i]);
                Console.WriteLine($"Значення {i + 1}: {value}");
            }
            foreach (string value in values)
            {
                int i = Convert.ToInt32(value);
                Uni u = (Uni)Math.Pow(2, i - 1);
                Console.WriteLine(uniname(u));
            }


            Console.ReadLine();
        }
        static string uniname(Uni u)
        {
            switch (u)
            {
                case Uni.DTEU: return "1.Державний торговельно економiчний унiверситет";
                case Uni.KPI: return "2.Київський полiтехнiчний iнститут";
                case Uni.KNU: return "3.Київський нацiональний унiверситет iменi Тараса Шевченка";
                case Uni.LNU: return "4.Львiвський нацiональний унiверситет iменi Iвана Франка";
                case Uni.HAR: return "5.Гарвардський унiверситет";
                case Uni.STAN: return "6.Стенфордський унiверситет";
                case Uni.MIT: return "7.Массачусетський технологiчний iнститут";
                case Uni.UCLA: return "8.Калiфорнiйський унiверситет в Лос-Анджелесi";
                default: return "Ви ввели неправильне число";
            }
        }
    }
}
