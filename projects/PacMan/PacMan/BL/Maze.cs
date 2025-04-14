using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    static class Maze
    {
        static char[,] maze = new char[24, 71];

        public static char[,] GetMaze() 
        {
            return maze;
        }
        //public static void SetMaze(char[,] newMaze)
        //{
        //    maze = newMaze;
        //}   

    }
}
