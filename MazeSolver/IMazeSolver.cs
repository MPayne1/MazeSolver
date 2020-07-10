using System.Collections.Generic;
using System.Windows;

namespace MazeSolver
{
    public interface IMazeSolver
    {
        void Solve(Maze maze);

        List<Point> GetResult();
    }
}
