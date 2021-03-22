using System;

namespace Lekcja13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K-koniec pracy");
            Console.WriteLine();

            while (true)
            {
                int number = GetValue();

                FizzBuzz game = new FizzBuzz(number);
                string answer = game.GetAnswer();
                Console.WriteLine(answer);
            }
        }

        private static int GetValue()
        {
            while (true)
            {
                Console.Write("Podaj liczbę: ");
                var val = Console.ReadLine();

                if (val.ToUpper() == "K")
                {
                    Console.WriteLine("Wybrano zakónczenie pracy");
                    Environment.Exit(0);
                }

                if (!int.TryParse(val, out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }

                return number;
            }
        }
    }
}
