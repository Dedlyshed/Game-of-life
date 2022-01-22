using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameOfLifeWF
{
    class GameOfLifeField : GameOfLifeCells
    {
        public Pen PenCells { get; set; }
        public Brush BrushCells { get; set; }
        public Pen PenGraphics { get; set; }
        public Color BackgroundColor { get; set; }
        public GameOfLifeField(int width, int height) : base (width, height) { BrushCells = Brushes.Lime; PenGraphics = new Pen(Color.DarkGray, 0.5f); }
        public GameOfLifeField(int width, int height, Brush brushCells, Pen penGraphics) : base(width, height) { BrushCells = brushCells; PenGraphics = penGraphics; }
        public void UpdateField(Graphics g)
        {
            g.Clear(Color.Black);
            for (int i = 25; i < Width; i += 25){
                g.DrawLine(PenGraphics, i, 0, i, Height);
            }
            for (int j = 25; j < Height; j+= 25)
            {
                g.DrawLine(PenGraphics, 0, j, Width, j);
            }
            for (int x = 1; x < Width - 1; x++)
            {
                for (int y = 1; y < Height - 1; y++)
                {
                    if (Cells[x, y]) g.FillRectangle(BrushCells, x, y, 1, 1);

                }
            }
        }
    }
}
