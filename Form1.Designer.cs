﻿namespace lab3kg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            splitContainer3 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ClearButton = new Button();
            DrawFigureButton = new Button();
            DrawAxisButton = new Button();
            splitContainer5 = new SplitContainer();
            StartStopButton = new Button();
            UpShiftButton = new Button();
            DownShiftButton = new Button();
            LeftShiftButton = new Button();
            RightShiftButton = new Button();
            ShiftLabel = new Label();
            DecreaseButton = new Button();
            IncreaseButton = new Button();
            ResizeLabel = new Label();
            splitContainer4 = new SplitContainer();
            splitContainer6 = new SplitContainer();
            BigRightRotateButton = new Button();
            SmallRightRotateButton = new Button();
            BigLeftRotateButton = new Button();
            SmallLeftRotateButton = new Button();
            CenterRotateLabel = new Label();
            YMirrorButton = new Button();
            XMirrorButton = new Button();
            MirrorLabel = new Label();
            TUSURButton = new Button();
            DrawTextLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(1299, 485);
            splitContainer1.SplitterDistance = 652;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(652, 485);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(643, 485);
            splitContainer3.SplitterDistance = 213;
            splitContainer3.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(ClearButton);
            splitContainer2.Panel1.Controls.Add(DrawFigureButton);
            splitContainer2.Panel1.Controls.Add(DrawAxisButton);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer5);
            splitContainer2.Size = new Size(213, 485);
            splitContainer2.SplitterDistance = 118;
            splitContainer2.TabIndex = 0;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClearButton.Location = new Point(0, 79);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(207, 29);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DrawFigureButton
            // 
            DrawFigureButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DrawFigureButton.Location = new Point(0, 44);
            DrawFigureButton.Name = "DrawFigureButton";
            DrawFigureButton.Size = new Size(207, 29);
            DrawFigureButton.TabIndex = 1;
            DrawFigureButton.Text = "Нарисовать фигуру";
            DrawFigureButton.UseVisualStyleBackColor = true;
            DrawFigureButton.Click += DrawFigureButton_Click;
            // 
            // DrawAxisButton
            // 
            DrawAxisButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DrawAxisButton.Location = new Point(0, 8);
            DrawAxisButton.Name = "DrawAxisButton";
            DrawAxisButton.Size = new Size(207, 29);
            DrawAxisButton.TabIndex = 0;
            DrawAxisButton.Text = "Нарисовать оси";
            DrawAxisButton.UseVisualStyleBackColor = true;
            DrawAxisButton.Click += DrawAxisButton_Click;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(StartStopButton);
            splitContainer5.Panel1.Controls.Add(UpShiftButton);
            splitContainer5.Panel1.Controls.Add(DownShiftButton);
            splitContainer5.Panel1.Controls.Add(LeftShiftButton);
            splitContainer5.Panel1.Controls.Add(RightShiftButton);
            splitContainer5.Panel1.Controls.Add(ShiftLabel);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(DecreaseButton);
            splitContainer5.Panel2.Controls.Add(IncreaseButton);
            splitContainer5.Panel2.Controls.Add(ResizeLabel);
            splitContainer5.Size = new Size(213, 363);
            splitContainer5.SplitterDistance = 227;
            splitContainer5.TabIndex = 0;
            // 
            // StartStopButton
            // 
            StartStopButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StartStopButton.Location = new Point(3, 183);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(207, 29);
            StartStopButton.TabIndex = 11;
            StartStopButton.Text = "Старт";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // UpShiftButton
            // 
            UpShiftButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UpShiftButton.Location = new Point(4, 151);
            UpShiftButton.Name = "UpShiftButton";
            UpShiftButton.Size = new Size(207, 29);
            UpShiftButton.TabIndex = 10;
            UpShiftButton.Text = "По оси OY вверх";
            UpShiftButton.UseVisualStyleBackColor = true;
            UpShiftButton.Click += UpShiftButton_Click;
            // 
            // DownShiftButton
            // 
            DownShiftButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DownShiftButton.Location = new Point(4, 116);
            DownShiftButton.Name = "DownShiftButton";
            DownShiftButton.Size = new Size(207, 29);
            DownShiftButton.TabIndex = 9;
            DownShiftButton.Text = "По оси OY вниз";
            DownShiftButton.UseVisualStyleBackColor = true;
            DownShiftButton.Click += DownShiftButton_Click;
            // 
            // LeftShiftButton
            // 
            LeftShiftButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LeftShiftButton.Location = new Point(3, 81);
            LeftShiftButton.Name = "LeftShiftButton";
            LeftShiftButton.Size = new Size(207, 29);
            LeftShiftButton.TabIndex = 8;
            LeftShiftButton.Text = "По оси ОХ влево";
            LeftShiftButton.UseVisualStyleBackColor = true;
            LeftShiftButton.Click += LeftShiftButton_Click;
            // 
            // RightShiftButton
            // 
            RightShiftButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RightShiftButton.Location = new Point(4, 46);
            RightShiftButton.Name = "RightShiftButton";
            RightShiftButton.Size = new Size(207, 29);
            RightShiftButton.TabIndex = 7;
            RightShiftButton.Text = "По оси ОХ вправо";
            RightShiftButton.UseVisualStyleBackColor = true;
            RightShiftButton.Click += RightShiftButton_Click;
            // 
            // ShiftLabel
            // 
            ShiftLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ShiftLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            ShiftLabel.Location = new Point(4, 12);
            ShiftLabel.Name = "ShiftLabel";
            ShiftLabel.Size = new Size(207, 31);
            ShiftLabel.TabIndex = 6;
            ShiftLabel.Text = "СДВиГ";
            ShiftLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DecreaseButton
            // 
            DecreaseButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DecreaseButton.Location = new Point(4, 72);
            DecreaseButton.Name = "DecreaseButton";
            DecreaseButton.Size = new Size(204, 29);
            DecreaseButton.TabIndex = 1;
            DecreaseButton.Text = "Уменьшить";
            DecreaseButton.UseVisualStyleBackColor = true;
            DecreaseButton.Click += DecreaseButton_Click;
            // 
            // IncreaseButton
            // 
            IncreaseButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IncreaseButton.Location = new Point(3, 37);
            IncreaseButton.Name = "IncreaseButton";
            IncreaseButton.Size = new Size(205, 29);
            IncreaseButton.TabIndex = 1;
            IncreaseButton.Text = "Увеличить";
            IncreaseButton.UseVisualStyleBackColor = true;
            IncreaseButton.Click += IncreaseButton_Click;
            // 
            // ResizeLabel
            // 
            ResizeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ResizeLabel.AutoSize = true;
            ResizeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ResizeLabel.Location = new Point(5, 3);
            ResizeLabel.Name = "ResizeLabel";
            ResizeLabel.Size = new Size(110, 31);
            ResizeLabel.TabIndex = 0;
            ResizeLabel.Text = "Масштаб";
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(splitContainer6);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(TUSURButton);
            splitContainer4.Panel2.Controls.Add(DrawTextLabel);
            splitContainer4.Size = new Size(426, 485);
            splitContainer4.SplitterDistance = 208;
            splitContainer4.TabIndex = 0;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(BigRightRotateButton);
            splitContainer6.Panel1.Controls.Add(SmallRightRotateButton);
            splitContainer6.Panel1.Controls.Add(BigLeftRotateButton);
            splitContainer6.Panel1.Controls.Add(SmallLeftRotateButton);
            splitContainer6.Panel1.Controls.Add(CenterRotateLabel);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(YMirrorButton);
            splitContainer6.Panel2.Controls.Add(XMirrorButton);
            splitContainer6.Panel2.Controls.Add(MirrorLabel);
            splitContainer6.Size = new Size(208, 485);
            splitContainer6.SplitterDistance = 254;
            splitContainer6.TabIndex = 0;
            // 
            // BigRightRotateButton
            // 
            BigRightRotateButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BigRightRotateButton.Location = new Point(1, 181);
            BigRightRotateButton.Name = "BigRightRotateButton";
            BigRightRotateButton.Size = new Size(203, 29);
            BigRightRotateButton.TabIndex = 9;
            BigRightRotateButton.Text = "много вправо";
            BigRightRotateButton.UseVisualStyleBackColor = true;
            BigRightRotateButton.Click += BigRightRotateButton_Click;
            // 
            // SmallRightRotateButton
            // 
            SmallRightRotateButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SmallRightRotateButton.Location = new Point(1, 146);
            SmallRightRotateButton.Name = "SmallRightRotateButton";
            SmallRightRotateButton.Size = new Size(203, 29);
            SmallRightRotateButton.TabIndex = 8;
            SmallRightRotateButton.Text = "немного вправо";
            SmallRightRotateButton.UseVisualStyleBackColor = true;
            SmallRightRotateButton.Click += SmallRightRotateButton_Click;
            // 
            // BigLeftRotateButton
            // 
            BigLeftRotateButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BigLeftRotateButton.Location = new Point(3, 111);
            BigLeftRotateButton.Name = "BigLeftRotateButton";
            BigLeftRotateButton.Size = new Size(201, 29);
            BigLeftRotateButton.TabIndex = 7;
            BigLeftRotateButton.Text = "много влево";
            BigLeftRotateButton.UseVisualStyleBackColor = true;
            BigLeftRotateButton.Click += BigLeftRotateButton_Click;
            // 
            // SmallLeftRotateButton
            // 
            SmallLeftRotateButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SmallLeftRotateButton.Location = new Point(2, 76);
            SmallLeftRotateButton.Name = "SmallLeftRotateButton";
            SmallLeftRotateButton.Size = new Size(198, 29);
            SmallLeftRotateButton.TabIndex = 6;
            SmallLeftRotateButton.Text = "немного влево";
            SmallLeftRotateButton.UseVisualStyleBackColor = true;
            SmallLeftRotateButton.Click += SmallLeftRotateButton_Click;
            // 
            // CenterRotateLabel
            // 
            CenterRotateLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CenterRotateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CenterRotateLabel.Location = new Point(2, 3);
            CenterRotateLabel.Name = "CenterRotateLabel";
            CenterRotateLabel.Size = new Size(194, 70);
            CenterRotateLabel.TabIndex = 5;
            CenterRotateLabel.Text = "Вращение отн. центра";
            // 
            // YMirrorButton
            // 
            YMirrorButton.Location = new Point(2, 114);
            YMirrorButton.Name = "YMirrorButton";
            YMirrorButton.Size = new Size(186, 29);
            YMirrorButton.TabIndex = 1;
            YMirrorButton.Text = "Отражение по OY";
            YMirrorButton.UseVisualStyleBackColor = true;
            YMirrorButton.Click += YMirrorButton_Click;
            // 
            // XMirrorButton
            // 
            XMirrorButton.Location = new Point(3, 79);
            XMirrorButton.Name = "XMirrorButton";
            XMirrorButton.Size = new Size(186, 29);
            XMirrorButton.TabIndex = 1;
            XMirrorButton.Text = "Отражение по OX";
            XMirrorButton.UseVisualStyleBackColor = true;
            XMirrorButton.Click += XMirrorButton_Click;
            // 
            // MirrorLabel
            // 
            MirrorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MirrorLabel.Location = new Point(9, 10);
            MirrorLabel.Name = "MirrorLabel";
            MirrorLabel.Size = new Size(175, 66);
            MirrorLabel.TabIndex = 0;
            MirrorLabel.Text = "Отражение отн. центра";
            // 
            // TUSURButton
            // 
            TUSURButton.Location = new Point(3, 40);
            TUSURButton.Name = "TUSURButton";
            TUSURButton.Size = new Size(210, 29);
            TUSURButton.TabIndex = 1;
            TUSURButton.Text = "ТУСУР!!!";
            TUSURButton.UseVisualStyleBackColor = true;
            TUSURButton.Click += TUSURButton_Click;
            // 
            // DrawTextLabel
            // 
            DrawTextLabel.AutoSize = true;
            DrawTextLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DrawTextLabel.Location = new Point(2, 6);
            DrawTextLabel.Name = "DrawTextLabel";
            DrawTextLabel.Size = new Size(197, 31);
            DrawTextLabel.TabIndex = 0;
            DrawTextLabel.Text = "Работа с текстом";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 485);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button DrawAxisButton;
        private Button ClearButton;
        private Button DrawFigureButton;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private Button StartStopButton;
        private Button UpShiftButton;
        private Button DownShiftButton;
        private Button LeftShiftButton;
        private Button RightShiftButton;
        private Label ShiftLabel;
        private Button DecreaseButton;
        private Button IncreaseButton;
        private Label ResizeLabel;
        private SplitContainer splitContainer6;
        private Button BigRightRotateButton;
        private Button SmallRightRotateButton;
        private Button BigLeftRotateButton;
        private Button SmallLeftRotateButton;
        private Label CenterRotateLabel;
        private Button YMirrorButton;
        private Button XMirrorButton;
        private Label MirrorLabel;
        private Label DrawTextLabel;
        private Button TUSURButton;
    }
}
