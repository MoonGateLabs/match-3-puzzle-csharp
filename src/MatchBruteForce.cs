using System;
using System.Collections.Generic;

namespace Match3PuzzleCsharp
{
    class MatchBruteForce
    {
        public const int CONST_MIN_STREAK = 3;

        int[,] matrix;

        int totalRows = 0;

        int totalColumns = 0;

        public MatchBruteForce(int[,] newMatrix)
        {
            matrix = newMatrix;
            totalRows = matrix.GetLength(0);
            totalColumns = matrix.GetLength(1);
        }

        public Dictionary<string, int[]>[] get345()
        {
            // so inefficient!!
            Dictionary<string, int[]>[] rows = getRow345();
            Dictionary<string, int[]>[] cols = getCol345();
            Dictionary<string, int[]>[] combo = new Dictionary<string, int[]>[rows.Length + cols.Length];
            for (int i = 0; i < combo.Length; i++)
            {
                if (i < rows.Length)
                {
                    combo[i] = rows[i];
                }
                else
                {
                    combo[i] = cols[i - rows.Length];
                }
            }
            return combo;
        }

        public Dictionary<string, int[]>[] getCol345()
        {
            List<Dictionary<string, int[]>> found = new List<Dictionary<string, int[]>>();
            int streakCol = 0;

            for (int col = 0; col < totalColumns; col++)
            {
                // reset streak
                streakCol = 0;
                int lastVal = 0;
                int[] streakStartCoords = { -1, -1 };
                int[] streakEndCoords = { -1, -1 };
                for (int row = 0; row < totalRows; row++)
                {
                    if (lastVal == matrix[row, col])
                    {
                        streakCol++;
                    }
                    else
                    {
                        // if had streak going
                        if (streakCol >= CONST_MIN_STREAK)
                        {
                            found.Add(
                                new Dictionary<string, int[]>{
                                    { "a", streakStartCoords },
                                    { "b", streakEndCoords }
                                }
                            );
                        }
                        lastVal = matrix[row, col];
                        streakCol = 1;

                        streakStartCoords = new int[] { row, col };
                        streakEndCoords = new int[] { -1, -1 };
                    }
                    if (streakCol >= CONST_MIN_STREAK)
                    {
                        streakEndCoords[0] = row;
                        streakEndCoords[1] = col;
                        if (row == totalRows - 1)
                        {
                            found.Add(
                               new Dictionary<string, int[]>{
                                    { "a", streakStartCoords },
                                    { "b", streakEndCoords }
                                }
                           );
                        }
                    }
                }
            }
            return found.ToArray();
        }

        public Dictionary<string, int[]>[] getRow345()
        {
            List<Dictionary<string, int[]>> found = new List<Dictionary<string, int[]>>();
            int streakRow = 0;

            for (int row = 0; row < totalRows; row++)
            {
                // reset streak
                streakRow = 0;
                int lastVal = 0;
                int[] streakStartCoords = { -1, -1 };
                int[] streakEndCoords = { -1, -1 };
                for (int col = 0; col < totalColumns; col++)
                {
                    if (lastVal == matrix[row, col])
                    {
                        streakRow++;
                    }
                    else
                    {
                        // if had streak going
                        if (streakRow >= CONST_MIN_STREAK)
                        {
                            found.Add(
                                new Dictionary<string, int[]>{
                                    { "a", streakStartCoords },
                                    { "b", streakEndCoords }
                                }
                            );
                        }
                        lastVal = matrix[row, col];
                        streakRow = 1;

                        streakStartCoords = new int[] { row, col };
                        streakEndCoords = new int[] { -1, -1 };
                    }
                    if (streakRow >= CONST_MIN_STREAK)
                    {
                        streakEndCoords[0] = row;
                        streakEndCoords[1] = col;
                        if (col == totalColumns - 1)
                        {
                            found.Add(
                               new Dictionary<string, int[]>{
                                    { "a", streakStartCoords },
                                    { "b", streakEndCoords }
                                }
                           );
                        }
                    }
                }
            }
            return found.ToArray();
        }
    }
}
