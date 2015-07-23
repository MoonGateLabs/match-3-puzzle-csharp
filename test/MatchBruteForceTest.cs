using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Match3PuzzleCsharp
{
    [TestFixture]
    class MatchBruteForceTest
    {
        [Test]
        public void Get345With3x3()
        {
            // arrange
            int[,] matrix = {  
                {1, 1, 1},
                {2, 3, 1},
                {5, 4, 1}
            };
            Dictionary<string, int[]>[] expected = {
                new Dictionary<string, int[]>{
                    { "a", new int[]{0,0} },
                    { "b", new int[]{0,2} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{0,2} },
                    { "b", new int[]{2,2} }
                }
            };
            Dictionary<string, int[]>[] result;
            MatchBruteForce match = new MatchBruteForce(matrix);

            // act
            result = match.get345();

            // assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected[0]["a"], result[0]["a"]);
            Assert.AreEqual(expected[0]["b"], result[0]["b"]);
            Assert.AreEqual(expected[1]["a"], result[1]["a"]);
            Assert.AreEqual(expected[1]["b"], result[1]["b"]);
        }

        [Test]
        public void Get345With4x4()
        {
            // arrange
            int[,] matrix = {  
                {1, 1, 1, 4},
                {2, 3, 1, 3},
                {2, 3, 1, 2},
                {5, 4, 1, 5}
            };
            Dictionary<string, int[]>[] expected = {
                new Dictionary<string, int[]>{
                    { "a", new int[]{0,0} },
                    { "b", new int[]{0,2} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{0,2} },
                    { "b", new int[]{3,2} }
                }
            };
            Dictionary<string, int[]>[] result;
            MatchBruteForce match = new MatchBruteForce(matrix);

            // act
            result = match.get345();

            // assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected[0]["a"], result[0]["a"]);
            Assert.AreEqual(expected[0]["b"], result[0]["b"]);
            Assert.AreEqual(expected[1]["a"], result[1]["a"]);
            Assert.AreEqual(expected[1]["b"], result[1]["b"]);
        }
    }
}
