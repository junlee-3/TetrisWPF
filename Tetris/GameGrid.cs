﻿namespace Tetris;

public class GameGrid
{
    private readonly int[,] grid;
    public int Rows { get; }
    public int Columns { get; }

    public int this[int r, int c]
    {
        get => grid[r, c];
        set => grid[r, c] = value;
        //2:39
    }
}