using System;

namespace FizzBuzzLab
{
    public class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(p.FizzBuzz(i));
            }
        }

        public string FizzBuzz(int number)
        {
            if(number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number == 42)
            {
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            }
            else if(number % 3 == 0)
            {
                return "Fizz";
            }
            else if(number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
