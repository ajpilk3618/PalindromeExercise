using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("", false)]
        [InlineData("taco cat", true)]
        [InlineData("1234321", true)]
        [InlineData("43212345", false)]
        [InlineData("lemons", false)]
        [InlineData("Hello World", false)]
        [InlineData("A new order began a more Roman age bred Rowena", true)]



        public void IsAPalindrime(string input, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(input);

            Assert.Equal(expected, actual);
        }
    }
}
