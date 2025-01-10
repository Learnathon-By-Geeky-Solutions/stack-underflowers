// Leetcode 36:Valid Sodoku

using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> rowSet = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {
                char item = board[i][j];
                if (rowSet.Contains(item))
                    return false;
                else if (item != '.')
                    rowSet.Add(item);
            }
        }
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> colSet = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {
                char item = board[j][i];
                if (colSet.Contains(item))
                    return false;
                else if (item != '.')
                    colSet.Add(item);
            }
        }
        int[][] startPositions = new int[][]
        {
            new int[] {0, 0}, new int[] {0, 3}, new int[] {0, 6},
            new int[] {3, 0}, new int[] {3, 3}, new int[] {3, 6},
            new int[] {6, 0}, new int[] {6, 3}, new int[] {6, 6}
        };
        foreach (var start in startPositions)
        {
            HashSet<char> boxSet = new HashSet<char>();
            for (int row = start[0]; row < start[0] + 3; row++)
            {
                for (int col = start[1]; col < start[1] + 3; col++)
                {
                    char item = board[row][col];
                    if (boxSet.Contains(item))
                        return false;
                    else if (item != '.')
                        boxSet.Add(item);
                }
            }
        }
        return true;
    }
}
