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

        [Test]
        public void Get345With7x7()
        {
            // arrange
            int[,] matrix = {  
                {1, 1, 1, 3, 2, 2, 2},
                {2, 3, 4, 5, 1, 1, 2},
                {2, 4, 4, 4, 4, 1, 2},
                {2, 3, 3, 3, 1, 4, 3},
                {2, 3, 5, 3, 1, 4, 3},
                {2, 3, 2, 3, 1, 4, 3},
                {5, 5, 5, 5, 5, 5, 5}
            };
            Dictionary<string, int[]>[] expected = {
                new Dictionary<string, int[]>{
                    { "a", new int[]{0,0} },
                    { "b", new int[]{0,2} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{0,4} },
                    { "b", new int[]{0,6} }
                },

                new Dictionary<string, int[]>{
                    { "a", new int[]{2,1} },
                    { "b", new int[]{2,4} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{3,1} },
                    { "b", new int[]{3,3} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{6,0} },
                    { "b", new int[]{6,6} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{1,0} },
                    { "b", new int[]{5,0} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{3,1} },
                    { "b", new int[]{5,1} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{3,3} },
                    { "b", new int[]{5,3} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{3,4} },
                    { "b", new int[]{5,4} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{3,5} },
                    { "b", new int[]{5,5} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{0,6} },
                    { "b", new int[]{2,6} }
                },
                new Dictionary<string, int[]>{
                    { "a", new int[]{3,6} },
                    { "b", new int[]{5,6} }
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
