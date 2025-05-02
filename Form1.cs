namespace lab3kg
{
    public partial class Form1 : Form
    {
        public float[,] kv = new float[5, 3]; // матрица тела
        public float[,] osi = new float[4, 3]; // матрица координат осей
        public float[,] matr_sdv = new float[3, 3]; // матрица преобразования
        public float a = 1, b = 0, c = 0, d = 1, m, n, p = 0, q = 0, s = 1;
        public bool f = true;
        public double fi = 0;
        private bool drawAxes = false;
        private bool drawFigure = false;
        // Мои переменные
        private bool drawWord = false;
        public float[,] word_dict = new float[1000, 3];
        public string word = "";
        public float[,] word_matr_sdv = new float[3, 3];
        public Color wordColor = Color.Green;
        public float wordSize = 1;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Очищаем PictureBox
            e.Graphics.Clear(pictureBox1.BackColor);

            if (drawAxes) Draw_osi(e.Graphics);
            if (drawFigure) Draw_Kv(e.Graphics);
            else if (drawWord) draw_word(e.Graphics);
        }

        private void DrawAxisButton_Click(object sender, EventArgs e)
        {
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            drawAxes = true;
            pictureBox1.Invalidate();
        }

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            drawFigure = true;
            drawWord = false;
            pictureBox1.Invalidate();
        }

        private void RightShiftButton_Click(object sender, EventArgs e)
        {
            m += 5;
            pictureBox1.Invalidate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            a = 1; b = 0; c = 0; d = 1; p = 0; q = 0; s = 1; fi = 0;
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            drawAxes = false;
            drawFigure = false;
            drawWord = false;
            pictureBox1.Invalidate();
        }

        private void LeftShiftButton_Click(object sender, EventArgs e)
        {
            m -= 5;
            pictureBox1.Invalidate();
        }

        private void DownShiftButton_Click(object sender, EventArgs e)
        {
            n += 5;
            pictureBox1.Invalidate();
        }

        private void UpShiftButton_Click(object sender, EventArgs e)
        {
            n -= 5;
            pictureBox1.Invalidate();
        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            s *= 0.9f;
            pictureBox1.Invalidate();
        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            s *= 1.11f;
            pictureBox1.Invalidate();
        }

        private void XMirrorButton_Click(object sender, EventArgs e)
        {
            d *= -1f;
            pictureBox1.Invalidate();
        }

        private void YMirrorButton_Click(object sender, EventArgs e)
        {
            a *= -1f;
            pictureBox1.Invalidate();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            StartStopButton.Text = "Стоп";
            if (f == true) timer1.Start();
            else
            {
                timer1.Stop();
                StartStopButton.Text = "Старт";
            }
            f = !f;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            m++;
            pictureBox1.Invalidate();
        }

        private void init_figure_12()
        {
            kv[0, 0] = 30; kv[0, 1] = 20; kv[0, 2] = 1;
            kv[1, 0] = 60; kv[1, 1] = 40; kv[1, 2] = 1;
            kv[2, 0] = 30; kv[2, 1] = -40; kv[2, 2] = 1;
            kv[3, 0] = -40; kv[3, 1] = -30; kv[3, 2] = 1;
            kv[4, 0] = -60; kv[4, 1] = 30; kv[4, 2] = 1;
        }

        private void Init_matr_preob(float a1, float b1, float c1, float d1, float m1, float n1, float p1, float q1, float s1, double fi1)
        {
            float[,] scaleMatr = new float[3, 3];
            scaleMatr[0, 0] = a1 / s1; scaleMatr[0, 1] = 0; scaleMatr[0, 2] = 0;
            scaleMatr[1, 0] = 0; scaleMatr[1, 1] = d1 / s1; scaleMatr[1, 2] = 0;
            scaleMatr[2, 0] = 0; scaleMatr[2, 1] = 0; scaleMatr[2, 2] = 1;

            float[,] rotateMatr = new float[3, 3];
            float cosFi = (float)Math.Cos(fi1);
            float sinFi = (float)Math.Sin(fi1);

            rotateMatr[0, 0] = cosFi; rotateMatr[0, 1] = sinFi; rotateMatr[0, 2] = 0;
            rotateMatr[1, 0] = -sinFi; rotateMatr[1, 1] = cosFi; rotateMatr[1, 2] = 0;
            rotateMatr[2, 0] = 0; rotateMatr[2, 1] = 0; rotateMatr[2, 2] = 1;

            float[,] translateMatr = new float[3, 3];
            translateMatr[0, 0] = 1; translateMatr[0, 1] = 0; translateMatr[0, 2] = 0;
            translateMatr[1, 0] = 0; translateMatr[1, 1] = 1; translateMatr[1, 2] = 0;
            translateMatr[2, 0] = m1; translateMatr[2, 1] = n1; translateMatr[2, 2] = 1;

            matr_sdv = Multiply_matr(Multiply_matr(scaleMatr, rotateMatr), translateMatr);
        }

        private void Init_osi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 200; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 200; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -200; osi[3, 2] = 1;
        }

        private float[,] Multiply_matr(float[,] A, float[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);

            float[,] r = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int k = 0; k < m; k++) r[i, j] += A[i, k] * B[k, j];
                }
            }
            return r;
        }

        private void Draw_Kv(Graphics g = null)
        {
            bool externalGraphics = g != null;
            Graphics gr = externalGraphics ? g : Graphics.FromHwnd(pictureBox1.Handle);

            try
            {
                init_figure_12();
                Init_matr_preob(a, b, c, d, m, n, p, q, s, fi);
                float[,] kv1 = Multiply_matr(kv, matr_sdv);

                using (Pen myPen = new Pen(Color.Blue, 2))
                {
                    gr.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
                    gr.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
                    gr.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
                    gr.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[4, 0], kv1[4, 1]);
                    gr.DrawLine(myPen, kv1[4, 0], kv1[4, 1], kv1[0, 0], kv1[0, 1]);
                }
            }
            finally
            {
                if (!externalGraphics) gr.Dispose();
            }
        }

        private void Draw_osi(Graphics g = null)
        {
            bool externalGraphics = g != null;
            Graphics gr = externalGraphics ? g : Graphics.FromHwnd(pictureBox1.Handle);

            try
            {
                Init_osi();
                Init_matr_preob(1, 0, 0, 1, pictureBox1.Width / 2, pictureBox1.Height / 2, 0, 0, 1, 0);
                float[,] osi1 = Multiply_matr(osi, matr_sdv);

                using (Pen myPen = new Pen(Color.Red, 1))
                {
                    gr.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);
                    gr.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);
                }
            }
            finally
            {
                if (!externalGraphics) gr.Dispose();
            }
        }

        private void SmallLeftRotateButton_Click(object sender, EventArgs e)
        {
            fi -= 15 * Math.PI / 180;
            pictureBox1.Invalidate();
        }

        private void BigLeftRotateButton_Click(object sender, EventArgs e)
        {
            fi -= 60 * Math.PI / 180;
            pictureBox1.Invalidate();
        }

        private void SmallRightRotateButton_Click(object sender, EventArgs e)
        {
            fi += 15 * Math.PI / 180;
            pictureBox1.Invalidate();
        }

        private void BigRightRotateButton_Click(object sender, EventArgs e)
        {
            fi += 60 * Math.PI / 180;
            pictureBox1.Invalidate();
        }


        // рисование тусура
        private void TUSURButton_Click(object sender, EventArgs e)
        {
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            word = "ТУСУРУ 63 ГОДА ★";
            draw_word();
            drawWord = true;
            drawFigure = false;
            pictureBox1.Invalidate();
        }
        // передел слова в массив
        private void init_word()
        {
            word_dict = new float[word.Length * 40, 3];
            var cyrillyc_dict = new CyrillicMatrixDictionary();
            for (int i = 0; i < word.Length; i++)
            {
                float[,] literal_vect = cyrillyc_dict.ReturnLiteral(word[i]);
                if (literal_vect == null) continue; // Добавьте проверку на null
                for (int j = 0; j < literal_vect.GetLength(0); j++) // Исправлено здесь
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (k == 0) word_dict[j + 40 * i, k] = literal_vect[j, k] + (i * 80 - word.Length * 40);
                        else word_dict[j + 40 * i, k] = literal_vect[j, k];
                    }
                }
            }
        }
        // рисование слова
        private void draw_word(Graphics g = null)
        {
            bool externalGraphics = g != null;
            Graphics gr = externalGraphics ? g : Graphics.FromHwnd(pictureBox1.Handle);
            try
            {
                init_word();
                float xOffset = m; // Начальная позиция X
                float yOffset = n; // Начальная позиция Y

                using (Pen myPen = new Pen(wordColor, wordSize))
                {
                    Init_matr_preob(a, b, c, d, xOffset, yOffset, p, q, s * 5, fi);
                    float[,] transformedWord = Multiply_matr(word_dict, matr_sdv);
                    // Рисуем линии символа
                    for (int j = 0; j < word_dict.GetLength(0) - 1; j++)
                    {
                        if (word_dict[j + 1, 2] + word_dict[j, 2] == 2) // Проверка на "поднятое перо"
                        {
                            gr.DrawLine(myPen,
                                transformedWord[j, 0], transformedWord[j, 1],
                                transformedWord[j + 1, 0], transformedWord[j + 1, 1]
                            );
                        }
                    }
                }
            }

            finally
            {
                if (!externalGraphics) gr.Dispose();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            m = (float)e.X;
            n = (float)e.Y;
            // Вызов диалогового окна для ввода текста
            string inputWord = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите слово:",
                "Ввод текста",
                ""
            );

            if (!string.IsNullOrEmpty(inputWord))
            {
                word = inputWord.ToUpper(); // Для совместимости с кириллицей в словаре
                drawWord = true;
                drawFigure = false;
                pictureBox1.Invalidate(); // Обновление отображения
            }
        }
    }
}
