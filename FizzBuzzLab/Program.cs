using System;
using System.Linq;

namespace FizzBuzzLab
{
    public class Program
    {
        private static void Main()
        {
            var p = new Program();

            foreach (var n in Enumerable.Range(1, 200))
                Console.WriteLine(p.FizzBuzz(n));
        }
        private bool Mod0(int a, int b) => a % b == 0;
        public string Answer = "Answer to the Ultimate Question of Life, the Universe, and Everything";

        public string FizzBuzz(int n)
        {
            if (n == 42)     return Answer;
            if (Mod0(n, 15)) return "FizzBuzz";
            if (Mod0(n, 3))  return "Fizz";
            if (Mod0(n, 5))  return "Buzz";

            return n.ToString();
        }
    }
}
