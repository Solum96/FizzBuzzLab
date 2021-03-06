﻿using System;
using System.Linq;
using System.Text;

namespace FizzBuzzLab
{
    public class Program
    {
        readonly string _answer = "Answer to the Ultimate Question of Life, the Universe, and Everything";

        private static void Main()
        {
            var p = new Program();

            Console.WriteLine(p.Looper(300));
        }

        public string Looper(int max) => string.Join(Environment.NewLine, Enumerable.Range(1, max).Select(n => FizzBuzz(n)).ToArray());
        bool Mod0(int a, int b) => a % b == 0;
        public string FizzBuzz(int n)
        {
            if (n == 42)     
                return _answer;
            
            if (Mod0(n, 3) && Mod0(n, 5)) 
                return "FizzBuzz";

            if (Mod0(n, 3))  
                return "Fizz";

            if (Mod0(n, 5))  
                return "Buzz";

            return n.ToString();
        }
    }
}
