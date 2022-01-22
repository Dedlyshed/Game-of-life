using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLifeWF
{
    class GameOfLifeShapes
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point TopLeftCorner { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool[,] ShapeCells { get; set; }
        public GameOfLifeShapes() { }
        public GameOfLifeShapes (Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
            Width = Math.Abs(Point1.X - Point2.X)+1;
            Height = Math.Abs(Point1.Y - Point2.Y)+1;

            int x; int y;
            if (point1.X < point2.X) x = point1.X;
            else x = point2.X;
            if (point1.Y < point2.Y) y = point1.Y;
            else y = point2.Y;
            TopLeftCorner = new Point(x, y);
        }
        
        public class Line : GameOfLifeShapes
        {
            public Line (Point point1, Point point2) : base (point1, point2) {}
            public Point[] TabulateLine ()
            {
                if ( Point1.X > Point2.X)
                {
                    Point tmp = Point1;
                    Point1 = Point2;
                    Point2 = tmp;
                }
                Point diference = new Point(Point2.X - Point1.X, Point2.Y - Point1.Y);
                Point[] linePoints = new Point[diference.X];
                for (int x = Point1.X, i = 0; x < Point2.X; x++, i++)
                {
                    linePoints[i].X = x;
                    linePoints[i].Y = (int)Math.Round((double)(Point1.Y + diference.Y * ((float)(x - Point1.X) / diference.X)));
                }
                return linePoints;
            }      
        }
        public class Rect : GameOfLifeShapes
        {
            public Rect(Point point1, Point point2) : base(point1, point2) { }
            public bool[,] ArrayRect ()
            {
                ShapeCells = new bool[Width, Height];
                for (int i = 0; i < Width; i++)
                {
                    ShapeCells[i, 0] = true;
                    ShapeCells[i, Height-1] = true;
                }
                for (int j = 0; j < Height; j++)
                {
                    ShapeCells[0, j] = true;
                    ShapeCells[Width-1, j] = true;
                }
                return ShapeCells;
            }
        }
        public class Elipse : GameOfLifeShapes
        {
            public Elipse (Point point1, Point point2) : base(point1, point2) { }
            public bool[,] ArrayElipse ()
            {
                ShapeCells = new bool[Width+1, Height+1];
                int x, y;
                for (float i = 0; i < 6.28; i+=0.01f)
                {
                    x = (int)Math.Round(Width/2.0 - (Width / 2.0) * Math.Cos(i));
                    y = (int)Math.Round(Height/2.0 - (Height / 2.0) * Math.Sin(i));
                    ShapeCells[x, y] = true;
                }
                return ShapeCells;
            }
        }

    }
}
