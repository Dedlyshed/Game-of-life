using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GameOfLifeWF
{
    public partial class MenuForm : Form
    {
        Graphics gLogo;
        Bitmap canvasLogo;
        GameOfLifeField logoAnimated;
        byte minDelay = 1;

        public MenuForm()
        {
            InitializeComponent();
            CreateLogo();
            AnimationLogo();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (numericUpDownWidth.Value == 0 || numericUpDownHeight.Value == 0)
            {
                MessageBox.Show(
                    "Field size not specified. Choose field size in menu.",
                    "Field size not specified",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }
            int width = (int)numericUpDownWidth.Value;
            int height = (int)numericUpDownHeight.Value;
            Game game = new Game(width, height, minDelay);
            game.Show();
            this.Hide();
        }

        private void CreateLogo()
        {
            logoAnimated = new GameOfLifeField(17, 17);
            byte[,] tmp =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (tmp[i, j] == 1) logoAnimated.Cells[i, j] = true;
                }
            }
            canvasLogo = new Bitmap(logoAnimated.Width*10, logoAnimated.Height*10);
            gLogo = Graphics.FromImage(canvasLogo);
            gLogo.ScaleTransform(10f, 10f);
            logoAnimated.UpdateField(gLogo);
            pictureBoxLogo.Image = canvasLogo;
        }

        private async void AnimationLogo()
        {
            for (int i = 0; i < 1000; i++)
            {
                logoAnimated.UpdateCells();
                logoAnimated.UpdateField(gLogo);
                pictureBoxLogo.Image = canvasLogo;
                await Task.Delay(400);
            }
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownWidth.Value = 175;
            numericUpDownHeight.Value = 100;
            minDelay = 1;
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownWidth.Value = 350;
            numericUpDownHeight.Value = 200;
            minDelay = 10;
        }

        private void radioButtonBig_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownWidth.Value = 625;
            numericUpDownHeight.Value = 450;
            minDelay = 20;
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownWidth.Value = 875;
            numericUpDownHeight.Value = 630;
            minDelay = 50;
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownWidth.Enabled = !numericUpDownWidth.Enabled;
            numericUpDownHeight.Enabled = !numericUpDownHeight.Enabled;
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e) { LagWarning(); }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e) { LagWarning(); }

        private void LagWarning()
        {
            int cellsAmount = (int)(numericUpDownHeight.Value * numericUpDownWidth.Value);
            if (cellsAmount > 500000) labelLagWarning.ForeColor = Color.Red;
            else labelLagWarning.ForeColor = Color.Goldenrod;
            labelLagWarning.Visible = true;
            if (cellsAmount < 250000) labelLagWarning.Visible = false;
        }
    }
}
