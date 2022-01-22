using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeWF
{
    public partial class Game : Form
    {
        //ініціалізація поля та графіки
        GameOfLifeField field;
        GameOfLifeShapes shape;
        Point canvasPoint = new Point();
        Graphics g;
        Bitmap canvas;
        //коеф. масштабування
        float scale = 1;
        //потрібно для асинхронної роботи гри
        bool stopgame = false;
        //режими малювання
        bool shapemode = false;
        bool linemode = false;
        bool rectmode = false;
        bool elipsemode = false;
        bool isdrawing = false;

        public Game(int width, int height, byte minDelay)
        {
            InitializeComponent();
            canvasBox.MouseWheel += CanvasBox_MouseWheel;
            field = new GameOfLifeField(width, height);
            GameOfLifeShapes shape = new GameOfLifeShapes();
            canvas = new Bitmap(field.Width, field.Height);
            g = Graphics.FromImage(canvas);
            Pen pen = new Pen(Color.Red, 10);
            canvasBox.Image = canvas;
            //0.76219 = 76.219% - це відсоток ширини поля з клітинками від всієї ширини вікна форми
            //початкове масштабування, в залежності від розміру поля
            scale = (float)Math.Round((this.Width * 0.75 / (field.Width)), 2);
            ScaleField();
            //встановлення мінімальної затримки між оновленням поля
            trackBarDelay.Minimum = minDelay;
            LabelDelay.Text = $"Delay ({trackBarDelay.Value} ms)";
        }

        //асинхронний метод нескінченно оновлює поле, доки користувач не натисте кнопку "стоп"
        private async void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonOneStep.Enabled = false;
            stopgame = false;
            while(true)
            {
                if (stopgame == true) break;
                field.UpdateCells();
                field.UpdateField(g);
                canvasBox.Image = canvas;
                await Task.Delay(trackBarDelay.Value);
            }
        }
        //зупиняє оновлення поля
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonOneStep.Enabled = true;
            stopgame = true;
        }

        private void buttonOneStep_Click(object sender, EventArgs e)
        {
            field.UpdateCells();
            field.UpdateField(g);
            canvasBox.Image = canvas;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            canvasBox.Width = 10000;
            canvasBox.Height = 10000;
            scale = (float)(this.Width * (1 - 120 / this.Width) / (field.Width));
            ScaleField();
        }

        private void CanvasBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) { scale += 0.15f; }
            else if (e.Delta < 0) { scale -= 0.15f; }
            if (scale <= 0) scale = 0.05f;
            else if (scale*field.Width >= 5500) scale -= 0.15f;
            ScaleField();
        }

        private void ScaleField()
        {
            scale = (float)Math.Round(scale, 2);
            if (scale == 0) scale = 1;
            canvas = new Bitmap((int)(field.Width * scale), (int)(field.Height * scale));
            g = Graphics.FromImage(canvas);
            g.ScaleTransform(scale, scale);
            field.UpdateField(g);
            canvasBox.Image = canvas;
            labelScale.Text = "Scale: " + scale + "x";
        }

        private void canvasBox_MouseMove(object sender, MouseEventArgs e)
        {
            canvasPoint.X = (int)(e.X / scale);
            canvasPoint.Y = (int)(e.Y / scale);
            labelCoords.Text = "(" + canvasPoint.X + ";" + canvasPoint.Y + ")";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            canvasBox.Top = -100 * e.NewValue;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            canvasBox.Left = -100 * e.NewValue;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void trackBarDelay_Scroll(object sender, EventArgs e)
        {
            LabelDelay.Text = $"Delay ({trackBarDelay.Value} ms)";
        }

        private void canvasBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (shapemode)
            {
                shape = new GameOfLifeShapes();
                if (e.Button.ToString() == "Left")
                {
                    shape.Point1 = canvasPoint;
                }
            }
            if (!shapemode)
            {
                isdrawing = true;
                if (e.Button.ToString() == "Left") DrawCells(true);
                else if (e.Button.ToString() == "Right") DrawCells(false);
            }
            
        }

        private void canvasBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (shapemode)
            {
                if (e.Button.ToString() == "Left")
                {
                    shape.Point2 = canvasPoint;
                    drawShape();
                }
            }
            isdrawing = false;
        }

        private async void DrawCells(bool draw)
        {
            while (isdrawing)
            {
                if (canvasPoint.X < field.Width && canvasPoint.Y < field.Height)
                {
                    field.Cells[canvasPoint.X, canvasPoint.Y] = draw;
                    field.UpdateField(g);
                    canvasBox.Image = canvas;
                }
                await Task.Delay(1);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            field.ClearCells();
            field.UpdateField(g);
            canvasBox.Image = canvas;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            shapemode = true;
            buttonRect.Enabled = true;
            buttonLine.Enabled = false;
            buttonElipse.Enabled = true;
            buttonPencil.Enabled = true;
            linemode = true;
            rectmode = false;
            elipsemode = false;
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            shapemode = true;
            buttonRect.Enabled = false;
            buttonLine.Enabled = true;
            buttonElipse.Enabled = true;
            buttonPencil.Enabled = true;
            linemode = false;
            rectmode = true;
            elipsemode = false;
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            shapemode = false;
            buttonRect.Enabled = true;
            buttonLine.Enabled = true;
            buttonElipse.Enabled = true;
            buttonPencil.Enabled = false;
            linemode = false;
            rectmode = false;
            elipsemode = false;
        }

        private void buttonElipse_Click(object sender, EventArgs e)
        {
            shapemode = true;
            buttonRect.Enabled = true;
            buttonLine.Enabled = true;
            buttonElipse.Enabled = false;
            buttonPencil.Enabled = true;
            linemode = false;
            rectmode = false;
            elipsemode = true;
        }

        private void drawShape()
        {
            if (linemode) field.AddLine(shape.Point1, shape.Point2);
            if (rectmode) field.AddRect(shape.Point1, shape.Point2);
            if (elipsemode) field.AddElipse(shape.Point1, shape.Point2);
            field.UpdateField(g);
            canvasBox.Image = canvas;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Dispose();
        }
    }
}
