using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(3, "Fizz")]
        [DataRow(6, "Fizz")]
        [DataRow(9, "Fizz")]
        [DataRow(12, "Fizz")]
        [DataTestMethod]
        public void Integer_divisible_by_3_return_Fizz(int input, string result)
        {
            FizzBuzzComputeAssert(input, result);
        }

        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        [DataTestMethod]
        public void Integer_divisible_by_5_return_Buzz(int input, string result)
        {
            FizzBuzzComputeAssert(input, result);
        }

        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(4, "4")]
        [DataRow(7, "7")]
        [DataRow(8, "8")]
        [DataRow(11, "11")]
        [DataTestMethod]
        public void Integer_no_divisible_by_5_or_3_return_the_input(int input, string result)
        {
            FizzBuzzComputeAssert(input, result);
        }

        [DataRow(15, "FizzBuzz")]
        [DataTestMethod]
        public void Integer_divisible_by_3_and_5_return_FizzBuzz(int input, string result)
        {
            FizzBuzzComputeAssert(input, result);
        }

        private static void FizzBuzzComputeAssert(int input, string result)
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz(input);
            string resultMethod = fizzBuzz.Compute();
            resultMethod.Should().Be(result);
        }
    }
}
