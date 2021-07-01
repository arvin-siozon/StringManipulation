using System.Collections.Generic;
using Xunit;

namespace Socks
{
    public class SocksTest
    {
        /*

        PART 1
                
        => Implement the `Socks.Count()` method, so that the following existing
           unit tests pass. Maybe also add some more (edge) test cases.

        The `pileOfSocks` parameter represents a "pile of sock colors" and the implementation should count
        the total number of socks.
         
        */

        [Theory]
        [InlineData( /*pileOfSocks:*/ "Red Red", /*                expectedOutput:*/ 2)]
        [InlineData( /*pileOfSocks:*/ "Red Red Black Black", /*    expectedOutput:*/ 4)]
        [InlineData( /*pileOfSocks:*/ "R R B B", /*                expectedOutput:*/ 4)]
        [InlineData( /*pileOfSocks:*/ "R R B B B R B R B B", /*    expectedOutput:*/ 10)]
        public void Test_Part1(string pileOfSocks, int expectedOutput)
        {
            var result = Socks.Count(pileOfSocks);

            Assert.Equal(expectedOutput, result);
        }

        /*

        PART 2
                
        => Implement the `Socks.CollectPairs()` method, so that the following existing
           unit tests pass. Maybe also add some more (edge) test cases.

        The `pileOfSocks` parameter represents a "pile of sock colors" and the implementation
        should find _pairs of matching colors_. See the `expectedOutput` below for examples.
         
        */

        [Theory]
        [InlineData( /*pileOfSocks:*/ "R R B B", /*                expectedOutput:*/ "1 x R pair, 1 x B pair")]
        [InlineData( /*pileOfSocks:*/ "Red Red", /*                expectedOutput:*/ "1 x Red pair")]
        [InlineData( /*pileOfSocks:*/ "Red Red Black Black", /*    expectedOutput:*/ "1 x Red pair, 1 x Black pair")]

        [InlineData( /*pileOfSocks:*/ "R R B B B R B R B B", /*    expectedOutput:*/ "2 x R pairs, 3 x B pairs")]
        [InlineData( /*pileOfSocks:*/ "Red Red Red Red", /*        expectedOutput:*/ "2 x Red pairs")]
        [InlineData( /*pileOfSocks:*/ "Y B Y R R R B R R G B R B R R R G R", /*expectedOutput:*/ "1 x Y pair, 2 x B pairs, 5 x R pairs, 1 x G pair")]
        public void Part2_Test(string pileOfSocks, string expectedOutput)
        {

            var result = Socks.CollectPairs(pileOfSocks);

            Assert.Equal(expectedOutput, result);
        }
    }

    public class Socks
    {
        public static int Count(string pileOfSocks)
        {
            return pileOfSocks.Split(" ").Length; ; // TODO: Replace this with your implementation
        }

        public static string CollectPairs(string pileOfSocks)
        {
            var result = "";

            var dict = new Dictionary<string, int>();
            foreach (string item in pileOfSocks.Split(" "))
            {
                //if(Equals(item,' '))
                if (item.CompareTo(" ") == 0)
                {
                    continue;
                }
                else
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict.Add(item, 1);
                    }
                }
            }
            var counter = 0;
            foreach (var item in dict)
            {
                var comma = "";
                var numberofPairs = (item.Value / 2);
                var pair = "";
                if(numberofPairs>1)
                {
                    pair = "pairs";
                }
                else
                {
                    pair = "pair";
                }
                if (counter == dict.Count-1)
                {
                    comma = "";
                }
                else
                {
                    if(dict.Count > 1)
                    {
                        comma = ",";
                    }
                    else
                    {
                        comma = "";
                    }
                }
                if (item.Value > 1)
                {
                    result += string.Format("{0} x {1} {2}{3} ", numberofPairs, item.Key, pair, comma);
                    //2 x R pairs,
                }
                counter++;
            }

            return result.Trim();
        }

    }
}