using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests
{
    public class Testing
    {
        [Theory]
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
            WordSmith wordReversed = new WordSmith();
            //Act
            var result = wordReversed.IsAPalidrome(x);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}

