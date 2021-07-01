using System;
using System.Collections.Generic;
using Xunit;

namespace Reverse
{
    public class ReverseTest
    {
        /*

        PART 1
                
        => Implement the `Reverse.Text()` method, so that the following existing
           unit tests pass. Maybe also add some more (edge) test cases.
         
        */

        [Theory]
        [InlineData( /*text:*/ "AB", /*     expectedOutput:*/ "BA")]
        [InlineData( /*text:*/ "ABCDE", /*  expectedOutput:*/ "EDCBA")]
        public void Test_Part1(string text, string expectedOutput)
        {
            var result = Reverse.Text(text);

            Assert.Equal(expectedOutput, result);
        }

        /*

        PART 2
                
        => Implement the `Reverse.Words()` method, so that the following existing
           unit tests pass. Maybe also add some more (edge) test cases.
         
        */

        [Theory]
        [InlineData( /*text:*/ "Hello", /*         expectedOutput:*/ "Hello")]
        [InlineData( /*text:*/ "Hello World", /*   expectedOutput:*/ "World Hello")]
        public void Test_Part2(string text, string expectedOutput)
        {
            var result = Reverse.Words(text);

            Assert.Equal(expectedOutput, result);
        }
    }

    public class Reverse
    {
        public static string Text(string sValue)
        {
            var result = "";
            for (int i = 0; i < sValue.Length; i++)
            {
                var count = sValue.Length - i - 1;
                var sValue2 = sValue[count];
                result += sValue2;
            }
            return result;

        }

        public static string Words(string words)
        {
            string result = "";
            string reverseWords = "";
            string[] ArrayWords = words.Split(new[] {" "}, StringSplitOptions.None);
            for (int i = ArrayWords.Length - 1; i >= 0; i--)
            {
                result += ArrayWords[i] + " ";
            }

            return result.Trim();
        }
    }
}