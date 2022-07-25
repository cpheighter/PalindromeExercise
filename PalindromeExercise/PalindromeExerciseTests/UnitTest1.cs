using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("bacon", false)]
        [InlineData("noon", true)]
        public void Test1(string x, bool expected)
        {
            //Arrange
            WordSmith wordsmith = new WordSmith();
            //Act
            var actual = wordsmith.IsAPalindrome(x);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
