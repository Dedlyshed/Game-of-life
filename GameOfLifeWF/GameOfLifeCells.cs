using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLifeWF
{
    class GameOfLifeCells
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool[,]Cells { get; set; }
        public GameOfLifeCells (int width, int height) { Width = width; Height = height; Cells = new bool[Width, Height]; }

        public int SeacrchForNeighbours(int x, int y)
        {
            int neigbours = 0;
            for (int i = -1; i<2; i++)
            {
                for (int j = -1; j<2; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (Cells[x+i, y+j] == true) neigbours++;
                }
            }
            return neigbours;
        }

        public void ClearCells()
        {
            Cells = new bool[Width, Height];
        }

        public void UpdateCells()
        {
            bool[,] tmp = new bool[Width, Height];
            for (int y = 1; y < Height - 1; y++)
            {
                for  (int x = 1; x < Width - 1; x++)
                {
                    int neighbours = SeacrchForNeighbours(x, y);
                    if (neighbours == 2 && Cells[x, y] == true) tmp[x, y] = true;
                    else if (neighbours == 3) tmp[x, y] = true;
                    if (neighbours < 2 || neighbours > 3) tmp[x, y] = false;
                }
            }
            for (int y = 1; y < Height - 1; y++)
            {
                for (int x = 1; x < Width -1; x++)
                {
                    Cells[x, y] = tmp[x, y];
                }
            }
        }

        public void AddLine(Point point1, Point point2)
        {
            GameOfLifeShapes.Line line = new GameOfLifeShapes.Line(point1, point2);
            Point[] linePoints = line.TabulateLine();
            for (int i = 0; i < linePoints.Length; i++)
            {
                Cells[linePoints[i].X, linePoints[i].Y] = true;
                if (i + 1 == linePoints.Length) continue;
                for (int j = linePoints[i].Y; j < linePoints[i + 1].Y; j++)
                {
                    Cells[linePoints[i].X, j] = true;
                }
                if (i - 1 < 0) continue;
                for (int k = linePoints[i].Y; k > linePoints[i + 1].Y; k--)
                {
                    Cells[linePoints[i].X, k] = true;
                }
            }
        }
        
        public void AddRect(Point point1, Point point2)
        {
            GameOfLifeShapes.Rect rect = new GameOfLifeShapes.Rect(point1, point2);
            bool[,] arrayRect = rect.ArrayRect();
            
            for (int i = 0; i < rect.Width; i++)
            {
                for (int j = 0; j < rect.Height; j++)
                {
                    if (arrayRect[i, j]) Cells[rect.TopLeftCorner.X + i, rect.TopLeftCorner.Y + j] = true;
                }
            }
        }

        public void AddElipse(Point point1, Point point2)
        {
            GameOfLifeShapes.Elipse elipse = new GameOfLifeShapes.Elipse(point1, point2);
            bool[,] arrayElipse = elipse.ArrayElipse();

            for (int i = 0; i < elipse.Width+1; i++)
            {
                for (int j = 0; j < elipse.Height+1; j++)
                {
                    if (arrayElipse[i, j]) Cells[elipse.TopLeftCorner.X + i, elipse.TopLeftCorner.Y + j] = true;
                }
            }
        }
    }
}
