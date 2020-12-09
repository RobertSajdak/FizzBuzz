using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.WriteLine("Podaj proszę swoją liczbę...");

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Podana przez Ciebie wartość NIE JEST LICZBĄ! Spróbuj ponownie.");
                }

                var fizzBuzz = new FizzBuzz(); //inicjalizacja obiektu klasy FizzBuzz
                Console.WriteLine(fizzBuzz.GetOutput(number)); //wypisanie wyniku w konsoli na wywołanej metodzie
            }
        }
    }
}