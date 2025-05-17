using System.Drawing;

namespace lab3kg
{
    public partial class Form1 : Form
    {
        public float[,] kv = new float[10, 3]; // матрица тела
        public float[,] osi = new float[4, 3]; // матрица координат осей
        public float[,] matr_sdv = new float[3, 3]; // матрица преобразования
        public float a = 1, b = 0, c = 0, d = 1, m, m1, n, n1, p = 0, q = 0, s = 1;
        public bool f = true;
        public double fi = 0;
        private bool drawAxes = false;
        private bool drawFigure = false;
        // переменные Дениса
        float[,] spsh = new float[15, 3]; // Матрица тела космического корабля
        float[,] trg = new float[5, 3]; // Матрица тела триугольника для космисческого корабля
        bool drawSpaceship; // Флаг для отрисовки космического корабля
        int cnt = 0; // Счётчик для изменения масштаба
        float sSpaceship = 1;
        double fiSpaceship = 0;
        // переменные Никиты
        private bool drawWord = false;
        public float[,] word_dict = new float[1000, 3];
        public string word = "";
        public float[,] word_matr_sdv = new float[3, 3];
        public Color wordColor = Color.Green;
        public float wordSize = 1;
        // переменные Ани
        private Color currentFigureColor = Color.Blue; // Цвет текущей фигуры
        private float[,] initialKv; // Сохраняем исходные координаты
        private float[,] currentTransformation = new float[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

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
            if (drawFigure) Draw_Figure(e.Graphics, currentFigureColor);
            else if (drawWord) draw_word(e.Graphics);
            else if (drawSpaceship)
            {
                Draw_Triangel(e.Graphics);
                Draw_Spaceship(e.Graphics);
            }
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
            Init_kvadrat();

            initialKv = (float[,])kv.Clone(); // Сохраняем исходные координаты

            pictureBox1.Invalidate();
        }

        private void RightShiftButton_Click(object sender, EventArgs e)
        {
            m1 += 5;
            pictureBox1.Invalidate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            a = 1; b = 0; c = 0; d = 1; p = 0; q = 0; s = 1; fi = 0; m1 = 0; n1 = 0;
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            drawAxes = false;
            drawFigure = false;
            drawWord = false;
            currentFigureColor = Color.Blue;
            pictureBox1.Invalidate();
        }

        private void LeftShiftButton_Click(object sender, EventArgs e)
        {
            m1 -= 5;
            pictureBox1.Invalidate();
        }

        private void DownShiftButton_Click(object sender, EventArgs e)
        {
            n1 += 5;
            pictureBox1.Invalidate();
        }

        private void UpShiftButton_Click(object sender, EventArgs e)
        {
            n1 -= 5;
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
            currentFigureColor = Color.Orange;
            pictureBox1.Invalidate();
        }

        private void YMirrorButton_Click(object sender, EventArgs e)
        {
            a *= -1f;
            currentFigureColor = Color.Brown;
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
            if (!drawSpaceship) m1++;
            else
            {
                fiSpaceship += 2 * Math.PI / 180;
                cnt++;
                if (cnt == 180)
                {
                    fiSpaceship = -45 * Math.PI / 180;
                    cnt = 0;
                }
                if (fiSpaceship < 135 * Math.PI / 180) sSpaceship *= 0.995f;
                else if (fiSpaceship > 135 * Math.PI / 180) sSpaceship *= 1.005f;
            }
            pictureBox1.Invalidate();
        }
        private void Init_strela()
        {
            kv = new float[10, 3];

            // Верхний левый угол 
            kv[0, 0] = -60; kv[0, 1] = 100; kv[0, 2] = 1;

            // Верхний правый угол
            kv[1, 0] = 40; kv[1, 1] = 100; kv[1, 2] = 1;

            // Нижний центральный угол 
            kv[2, 0] = 40; kv[2, 1] = -50; kv[2, 2] = 1;

            // Нижний правый угол 
            kv[3, 0] = 0; kv[3, 1] = -10; kv[3, 2] = 1;

            // Нижний левый угол 
            kv[4, 0] = -40; kv[4, 1] = -50; kv[4, 2] = 1;

            // Снова верхний левый угол 
            kv[5, 0] = -60; kv[5, 1] = 100; kv[5, 2] = 1;


        }
        private void init_figure_12()
        {
            kv = new float[10, 3];
            kv[0, 0] = 30; kv[0, 1] = 20; kv[0, 2] = 1;
            kv[1, 0] = 60; kv[1, 1] = 40; kv[1, 2] = 1;
            kv[2, 0] = 30; kv[2, 1] = -40; kv[2, 2] = 1;
            kv[3, 0] = -40; kv[3, 1] = -30; kv[3, 2] = 1;
            kv[4, 0] = -60; kv[4, 1] = 30; kv[4, 2] = 1;
            kv[5, 0] = 30; kv[5, 1] = 20; kv[5, 2] = 1;
        }
        private void init_figure_den()
        {
            kv = new float[7, 3];
            kv[0, 0] = -60; kv[0, 1] = 120; kv[0, 2] = 1;
            kv[1, 0] = 80; kv[1, 1] = 50; kv[1, 2] = 1;
            kv[2, 0] = 10; kv[2, 1] = 0; kv[2, 2] = 1;
            kv[3, 0] = 80; kv[3, 1] = -50; kv[3, 2] = 1;
            kv[4, 0] = -90; kv[4, 1] = -90; kv[4, 2] = 1;
            kv[5, 0] = -60; kv[5, 1] = 120; kv[5, 2] = 1;
        }

        private void Init_Triangle()
        {
            trg[0, 0] = 0; trg[0, 1] = -12; trg[0, 2] = 1;
            trg[1, 0] = (float)Math.Cos(30 * Math.PI / 180) * 6; trg[1, 1] = 0; trg[1, 2] = 1;
            trg[2, 0] = (float)-Math.Cos(30 * Math.PI / 180) * 6; trg[2, 1] = 0; trg[2, 2] = 1;
            trg[3, 0] = 0; trg[3, 1] = -12; trg[3, 2] = 1;
        }

        private void Init_Spaseship()
        {
            spsh[0, 0] = 20; spsh[0, 1] = -50; spsh[0, 2] = 1;
            spsh[1, 0] = 30; spsh[1, 1] = -60; spsh[1, 2] = 1;
            spsh[2, 0] = 40; spsh[2, 1] = -50; spsh[2, 2] = 1;
            spsh[3, 0] = 40; spsh[3, 1] = -60; spsh[3, 2] = 1;
            spsh[4, 0] = 50; spsh[4, 1] = -50; spsh[4, 2] = 1;
            spsh[5, 0] = 50; spsh[5, 1] = -40; spsh[5, 2] = 1;
            spsh[6, 0] = 60; spsh[6, 1] = -30; spsh[6, 2] = 1;
            spsh[7, 0] = 60; spsh[7, 1] = -20; spsh[7, 2] = 1;
            spsh[8, 0] = 50; spsh[8, 1] = -20; spsh[8, 2] = 1;
            spsh[9, 0] = 40; spsh[9, 1] = -30; spsh[9, 2] = 1;
            spsh[10, 0] = 30; spsh[10, 1] = -30; spsh[10, 2] = 1;
        }

        private void Init_figure_8()
        {
            kv[0, 0] = -100; kv[0, 1] = -90; kv[0, 2] = 1; // Левый верхний
            kv[1, 0] = -100; kv[1, 1] = 90; kv[1, 2] = 1;  // Левый нижний
            kv[2, 0] = 0; kv[2, 1] = 60; kv[2, 2] = 1;  // Нижний излом
            kv[3, 0] = 100; kv[3, 1] = 90; kv[3, 2] = 1;   // Правый нижний
            kv[4, 0] = 100; kv[4, 1] = -90; kv[4, 2] = 1;  // Правый верхний
            kv[5, 0] = 0; kv[5, 1] = -60; kv[5, 2] = 1;  // Верхний излом
            kv[6, 0] = -100; kv[6, 1] = -90; kv[6, 2] = 1; // Замкнуть контур
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
            int m = B.GetLength(1);

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
        private void Init_kvadrat()
        {
            kv = new float[10, 3];
            kv[0, 0] = -50; kv[0, 1] = 0; kv[0, 2] = 1;
            kv[1, 0] = 0; kv[1, 1] = 50; kv[1, 2] = 1;
            kv[2, 0] = 50; kv[2, 1] = 0; kv[2, 2] = 1;
            kv[3, 0] = 0; kv[3, 1] = -50; kv[3, 2] = 1;
            kv[4, 0] = -50; kv[4, 1] = 0; kv[4, 2] = 1;
        }

        private void Draw_Figure(Graphics g, Color color)
        {
            bool externalGraphics = g != null;
            Graphics gr = externalGraphics ? g : Graphics.FromHwnd(pictureBox1.Handle);

            try
            {
                Init_matr_preob(a, b, c, d, m + m1, n + n1, p, q, s, fi);
                float[,] kv1 = Multiply_matr(kv, matr_sdv);

                using (Pen myPen = new Pen(color, 2))
                {
                    for (int i = 0; i < kv.GetLength(0) - 1; i++)
                    {
                        if (kv[i, 2] + kv[i + 1, 2] > 1)
                        {
                            gr.DrawLine(myPen, kv1[i, 0], kv1[i, 1], kv1[(i + 1) % kv.GetLength(0), 0], kv1[(i + 1) % kv.GetLength(0), 1]);
                        }
                    }
                }
            }
            finally
            {
                if (!externalGraphics) gr.Dispose();
            }
        }
        private void Draw_Triangel(Graphics g = null)
        {
            bool externalGraphics = g != null;
            Graphics gr = externalGraphics ? g : Graphics.FromHwnd(pictureBox1.Handle);

            Init_Triangle();
            try
            {
                Init_matr_preob(a, b, c, d, m, n, p, q, s, fi);
                float[,] trg1 = Multiply_matr(trg, matr_sdv);

                using (Pen myPen = new Pen(Color.Blue, 2))
                {
                    int i = 0;
                    while (trg[i, 2] + trg[(i + 1) % trg.GetLength(0), 2] > 1)
                    {
                        g.DrawLine(myPen, trg1[i, 0], trg1[i, 1], trg1[(i + 1) % (kv.GetLength(0)), 0], trg1[(i + 1) % (kv.GetLength(0)), 1]);
                        i++;
                    }
                }
            }
            finally
            {
                if (!externalGraphics) gr.Dispose();
            }
        }

        private void Draw_Spaceship(Graphics g = null)
        {
            bool externalGraphics = g != null;
            Graphics gr = externalGraphics ? g : Graphics.FromHwnd(pictureBox1.Handle);

            Init_Spaseship();

            try
            {
                Init_matr_preob(a, b, c, d, m, n, p, q, sSpaceship, fiSpaceship);
                float[,] spsh1 = Multiply_matr(spsh, matr_sdv);

                using (Pen myPen = new Pen(Color.Blue, 2))
                {
                    int i = 0;
                    while (spsh[i, 2] + spsh[(i + 1) % spsh.GetLength(0), 2] > 1)
                    {
                        g.DrawLine(myPen, spsh1[i, 0], spsh1[i, 1], spsh1[(i + 1) % (kv.GetLength(0)), 0], spsh1[(i + 1) % (kv.GetLength(0)), 1]);
                        i++;
                    }
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
                if (literal_vect == null) continue;
                for (int j = 0; j < literal_vect.GetLength(0); j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (k == 0) word_dict[j + 40 * i, k] = literal_vect[j, k] + (i * 100 - word.Length * 50);
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
                float xOffset = m;
                float yOffset = n;

                using (Pen myPen = new Pen(wordColor, wordSize))
                {
                    Init_matr_preob(a, b, c, d, xOffset + m1, yOffset + n1, p, q, s * 5, fi);
                    float[,] transformedWord = Multiply_matr(word_dict, matr_sdv);
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
            m = e.X;
            n = e.Y;
            // Вызов диалогового окна для ввода текста
            if (drawWord)
            {
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
                    pictureBox1.Invalidate();
                }
            }
            if (drawSpaceship)
            {
                fi = 0;
                fiSpaceship = -45 * Math.PI / 180;
                s = 1;
                sSpaceship = 1;
                a = 1;
                d = 1;
                cnt = 0;
                timer1.Start();
            }
        }

        private void KsuhaButton_Click(object sender, EventArgs e)
        {
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            s = 1;
            drawFigure = true;
            drawWord = false;
            Init_strela();
            pictureBox1.Invalidate();
        }

        private void DenisButton_Click(object sender, EventArgs e)
        {
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            s = 1;
            drawFigure = true;
            drawWord = false;
            init_figure_den();
            pictureBox1.Invalidate();
        }

        private void AnnaButton_Click(object sender, EventArgs e)
        {
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            drawFigure = true;
            drawWord = false;
            Init_figure_8();
            pictureBox1.Invalidate();
        }

        private void NikitaButton_Click(object sender, EventArgs e)
        {
            m = pictureBox1.Width / 2;
            n = pictureBox1.Height / 2;
            drawFigure = true;
            drawWord = false;
            init_figure_12();
            pictureBox1.Invalidate();
        }

        private void XMirrorRelativeStart_Click(object sender, EventArgs e)
        {
            initialKv = kv;
            ReflectXOrigin();
            // Кнопка для отражения относительно оси X
        }

        private void YMirrorRelativeStart_Click(object sender, EventArgs e)
        {
            initialKv = kv;
            ReflectYOrigin();
            // Кнопка для отражения относительно оси Y
        }

        private void XYMirrorRelativeStart_Click(object sender, EventArgs e)
        {
            ReflectXYOrigin();  // Отражаем относительно X = Y
        }

        private void XYMirrorRelativeCurrent_Click(object sender, EventArgs e)
        {
            ReflectXYCurrent(); // Кнопка для отражения относительно прямой X=Y
        }

        private void ReflectXOrigin()
        {
            n = pictureBox1.Height / 2;
            m = pictureBox1.Width / 2;
            currentFigureColor = Color.Red;
            n1 = -n1;

            d *= -1;
            pictureBox1.Invalidate();


        }

        // Отражение относительно оси Y (относительно начала координат)
        private void ReflectYOrigin()
        {
            n = pictureBox1.Height / 2;
            m = pictureBox1.Width / 2;
            currentFigureColor = Color.Blue;
            m1 = -m1;

            a *= -1;
            pictureBox1.Invalidate();
        }

        // Отражение относительно прямой X=Y (относительно начала координат)
        private void ReflectXYOrigin()
        {
            n = pictureBox1.Height / 2;
            m = pictureBox1.Width / 2;

            m1 = -m1;
            n1 = -n1;

            d *= -1;
            a *= -1;
            currentFigureColor = Color.Green;
            pictureBox1.Invalidate();

        }



        // Отражение относительно прямой X=Y (относительно текущих координат)
        private void ReflectXYCurrent()
        {
            a*= -1;
            d*= -1;

            currentFigureColor = Color.Pink;
            pictureBox1.Invalidate();
        }

        private void Button_DrawWord_Click(object sender, EventArgs e)
        {
            
            drawWord = true;
            drawSpaceship = false;
        }

        private void Button_DrawSpaceship_Click(object sender, EventArgs e)
        {
            drawWord = false;
            drawSpaceship = true;
        }
    }
}

