using PalindromeExercise;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("Racecar", true)]
        [InlineData("civic", true)]
        [InlineData("hello", false)]
        [InlineData("Good", false)]
        [InlineData("", false)]
        [InlineData("null", false)]
        public void Test1(string x, bool expected)
        {
            //Arrange
            WordSmith  wordReversed = new WordSmith();
            //Act
            var result = wordReversed.IsAPalidrome(x);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
