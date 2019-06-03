using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(7, "7")]
        [DataRow(8, "8")]
        [DataRow(9, "Fizz")]
        [DataRow(10, "Buzz")]
        [DataRow(11, "11")]
        [DataRow(12, "Fizz")]
        [DataTestMethod]
        public void TestMethod1(int input, string result)
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz(input);
            string resultMethod = fizzBuzz.Compute();
            resultMethod.Should().Be(result);
        }
    }
}
