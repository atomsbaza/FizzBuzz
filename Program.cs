using System;

namespace balloonone.fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FizzBuzz fizzBuzz = new FizzBuzz();
                Console.WriteLine("Enter a non-negative number to start looping from");
                int startPoint = fizzBuzz.CheckIsNumber();
                Console.WriteLine("Enter a non - negative number to End looping from");
                int endPoint = fizzBuzz.CheckIsNumber();
                string result = fizzBuzz.ReturnFizzBuzzOutput(startPoint, endPoint);
                Console.WriteLine(result);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
