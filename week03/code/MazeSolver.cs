using System;
using System.Collections.Generic;

public class MazeSolver
{
    public static (int x, int y) MoveLeft(Dictionary<(int, int), (bool left, bool right, bool up, bool down)> maze, int x, int y)
    {
        if (maze.ContainsKey((x, y)) && maze[(x, y)].left)
        {
            return (x - 1, y);
        }
        return (x, y);
    }

    public static (int x, int y) MoveRight(Dictionary<(int, int), (bool left, bool right, bool up, bool down)> maze, int x, int y)
    {
        if (maze.ContainsKey((x, y)) && maze[(x, y)].right)
        {
            return (x + 1, y);
        }
        return (x, y);
    }

    public static (int x, int y) MoveUp(Dictionary<(int, int), (bool left, bool right, bool up, bool down)> maze, int x, int y)
    {
        if (maze.ContainsKey((x, y)) && maze[(x, y)].up)
        {
            return (x, y - 1);
        }
        return (x, y);
    }

    public static (int x, int y) MoveDown(Dictionary<(int, int), (bool left, bool right, bool up, bool down)> maze, int x, int y)
    {
        if (maze.ContainsKey((x, y)) && maze[(x, y)].down)
        {
            return (x, y + 1);
        }
        return (x, y);
    }
}
