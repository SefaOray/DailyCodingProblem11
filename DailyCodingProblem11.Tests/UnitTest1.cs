using System;
using Xunit;
using DailyCodingProblem11;

namespace DailyCodingProblem11.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new string[] { "dog", "deer", "deal" }, new string[] { "deer", "deal" }, "de")]
        public void test_GetAutoCompleteResult(string[] qs, string[] expectedResult, string prefix)
        {
            var result = Program.GetAutoCompleteResult(prefix, qs);

            Assert.Equal(expectedResult, result);
        }
    }
}
