
namespace GameOfLifeWF
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.canvasBox = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelScale = new System.Windows.Forms.Label();
            this.labelCoords = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonElipse = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.LabelDelay = new System.Windows.Forms.Label();
            this.trackBarDelay = new System.Windows.Forms.TrackBar();
            this.buttonStop = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOneStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasBox
            // 
            this.canvasBox.BackColor = System.Drawing.Color.Transparent;
            this.canvasBox.Location = new System.Drawing.Point(0, -3);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(1000, 1000);
            this.canvasBox.TabIndex = 0;
            this.canvasBox.TabStop = false;
            this.canvasBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasBox_MouseDown);
            this.canvasBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasBox_MouseMove);
            this.canvasBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasBox_MouseUp);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(4, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(143, 32);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelScale
            // 
            this.labelScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(4, 439);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(51, 13);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Scale: 1x";
            // 
            // labelCoords
            // 
            this.labelCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(98, 439);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(31, 13);
            this.labelCoords.TabIndex = 4;
            this.labelCoords.Text = "(0; 0)";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 447);
            this.hScrollBar1.Maximum = 109;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(644, 15);
            this.hScrollBar1.TabIndex = 5;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(625, -3);
            this.vScrollBar1.Maximum = 109;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 450);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.buttonOneStep);
            this.groupBox1.Controls.Add(this.buttonMenu);
            this.groupBox1.Controls.Add(this.buttonElipse);
            this.groupBox1.Controls.Add(this.buttonPencil);
            this.groupBox1.Controls.Add(this.buttonRect);
            this.groupBox1.Controls.Add(this.buttonLine);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.LabelDelay);
            this.groupBox1.Controls.Add(this.trackBarDelay);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.labelScale);
            this.groupBox1.Controls.Add(this.labelCoords);
            this.groupBox1.Location = new System.Drawing.Point(642, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 465);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(4, 312);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(143, 32);
            this.buttonMenu.TabIndex = 14;
            this.buttonMenu.Text = "Меню";
            this.toolTip1.SetToolTip(this.buttonMenu, "Повернутися до головного меню");
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonElipse
            // 
            this.buttonElipse.Location = new System.Drawing.Point(77, 274);
            this.buttonElipse.Name = "buttonElipse";
            this.buttonElipse.Size = new System.Drawing.Size(70, 32);
            this.buttonElipse.TabIndex = 13;
            this.buttonElipse.Text = "Овал";
            this.toolTip1.SetToolTip(this.buttonElipse, "Зажміть мишу у першій точці еліпса та відпустіть у другій");
            this.buttonElipse.UseVisualStyleBackColor = true;
            this.buttonElipse.Click += new System.EventHandler(this.buttonElipse_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Location = new System.Drawing.Point(4, 198);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(143, 32);
            this.buttonPencil.TabIndex = 12;
            this.buttonPencil.Text = "Олівець";
            this.toolTip1.SetToolTip(this.buttonPencil, "Зажміть мишу і водіть нею по полю");
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonRect
            // 
            this.buttonRect.Location = new System.Drawing.Point(77, 236);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(70, 32);
            this.buttonRect.TabIndex = 11;
            this.buttonRect.Text = "Прямокут.";
            this.toolTip1.SetToolTip(this.buttonRect, "Зажміть мишу у верхньому лівому куті прямокутинка та відпустіть у нижньому правом" +
        "у куті");
            this.buttonRect.UseVisualStyleBackColor = true;
            this.buttonRect.Click += new System.EventHandler(this.buttonRect_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(4, 236);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(70, 32);
            this.buttonLine.TabIndex = 9;
            this.buttonLine.Text = "Лінія";
            this.toolTip1.SetToolTip(this.buttonLine, "Зажміть мишу у першій точці лініі та відпустіть у другій");
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(4, 274);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 32);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очистити";
            this.toolTip1.SetToolTip(this.buttonClear, "Очищає поле від клітинок");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // LabelDelay
            // 
            this.LabelDelay.AutoSize = true;
            this.LabelDelay.Location = new System.Drawing.Point(48, 130);
            this.LabelDelay.Name = "LabelDelay";
            this.LabelDelay.Size = new System.Drawing.Size(65, 13);
            this.LabelDelay.TabIndex = 7;
            this.LabelDelay.Text = "Delay (1 ms)";
            // 
            // trackBarDelay
            // 
            this.trackBarDelay.Location = new System.Drawing.Point(4, 156);
            this.trackBarDelay.Maximum = 500;
            this.trackBarDelay.Minimum = 1;
            this.trackBarDelay.Name = "trackBarDelay";
            this.trackBarDelay.Size = new System.Drawing.Size(143, 45);
            this.trackBarDelay.TabIndex = 6;
            this.trackBarDelay.Value = 1;
            this.trackBarDelay.Scroll += new System.EventHandler(this.trackBarDelay_Scroll);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(4, 57);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(143, 32);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonOneStep
            // 
            this.buttonOneStep.Location = new System.Drawing.Point(4, 95);
            this.buttonOneStep.Name = "buttonOneStep";
            this.buttonOneStep.Size = new System.Drawing.Size(143, 32);
            this.buttonOneStep.TabIndex = 15;
            this.buttonOneStep.Text = "Один крок";
            this.buttonOneStep.UseVisualStyleBackColor = true;
            this.buttonOneStep.Click += new System.EventHandler(this.buttonOneStep_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.canvasBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game Of Life";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label LabelDelay;
        private System.Windows.Forms.TrackBar trackBarDelay;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonRect;
        private System.Windows.Forms.Button buttonElipse;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonOneStep;
    }
}

