using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int input;

        public FizzBuzz(int input)
        {
            this.input = input;
        }

        public string Compute()
        {
            if (this.input % 5 == 0 && this.input % 3 == 0)
                return "FizzBuzz";
            if (this.input % 3 == 0)
                return "Fizz";
            if (this.input % 5 == 0)
                return "Buzz";
            return this.input.ToString();
        }
    }
}