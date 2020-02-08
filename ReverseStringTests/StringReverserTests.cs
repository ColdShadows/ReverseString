using System;
using Xunit;

namespace ReverseString
{
    public class StringReverserTests
    {
        [Theory]
        [InlineData("Hello", "olleH")]
        [InlineData("F", "F")]
        [InlineData("!@#$", "$#@!")]
        [InlineData("", "")]
        public void Reverse_GivenString_ReturnsReversed(string input, string expected)
        {
            var result = StringReverser.ReverseString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Reverse_GivenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>  StringReverser.ReverseString(null));
        }
    }
}
