using System;
using System.Collections.Generic;

namespace Match3PuzzleCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {  
                {1, 1, 1, 4},
                {2, 3, 1, 3},
                {2, 3, 1, 2},
                {5, 4, 1, 5}
            };
            MatchBruteForce match = new MatchBruteForce(matrix);

            Dictionary<string, int[]>[] result = match.get345();
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("res:" + i);
                Console.WriteLine("a=[" + result[i]["a"][0] + "," + result[i]["a"][1] + "]");
                Console.WriteLine("b=[" + result[i]["b"][0] + "," + result[i]["b"][1] + "]");
            }
            Console.ReadLine();
        }
    }
}
