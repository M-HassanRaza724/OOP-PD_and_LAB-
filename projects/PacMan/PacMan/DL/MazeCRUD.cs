using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.BL;

namespace PacMan.DL
{
    class MazeCRUD
    {
        public static void readData()
        {

            StreamReader fp = new StreamReader("maze.txt");
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < 71; x++)
                {
                    Maze.SetMaze(row, x, record[x]);
                }
                row++;
            }

            fp.Close();
        }
    }
}
