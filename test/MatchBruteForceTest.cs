using System;
using NUnit.Framework;

namespace Match3PuzzleCsharp
{
    [TestFixture]
    class MatchBruteForceTest
    {
        [Test]
        public void BubbleSort()
        {
            // arrange
            MatchBruteForce match = new MatchBruteForce();
            int[,] matrix = {  
                {1, 1, 1},
                {2, 3, 1},
                {5, 4, 1}
            };
            int[,] sortedArray;

            // act
            int[,] result = match.get345();

            // assert
            Assert.AreEqual(1, sortedArray[0]);
            Assert.AreEqual(2, sortedArray[1]);
            Assert.AreEqual(3, sortedArray[2]);
            Assert.AreEqual(4, sortedArray[3]);
            Assert.AreEqual(5, sortedArray[4]);
            Assert.AreEqual(10, sortedArray[9]);
        }
    }
}
