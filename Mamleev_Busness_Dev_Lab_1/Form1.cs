using System.Windows.Forms;

namespace Mamleev_Busness_Dev_Lab_1
{
    public partial class Form1 : Form
    {
        private Font font;
        private SolidBrush brush;

        private void FontButton_Click(object sender, EventArgs e)
        {
            //если выбор шрифта завершен нажатием кнопки OK
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //получить параметры шрифта из диалогового окна 
                font = fontDialog1.Font;
                //получить цвет шрифта из того же окна
                brush.Color = fontDialog1.Color;
            }
        }

        private double f(double x)
        {
            return Math.Log(1+Math.Pow(x,2))+Math.Pow(Math.Sin(x/3), 2);
        }
        private void GraphicButton_Click(object sender, EventArgs e)
        {
            //Начало координат графика
            int x0 = 15;
            int y0 = (int)(pictureBox1.Height * 0.85);
            //Масштаб по оси Х
            int Mx = pictureBox1.Width - 2 * x0;
            //Масштаб по оси Y
            int My = -y0 + 10;
            //Число точек графика			
            int M = (int)PointsNumericUpDown.Value;

            //Создание графического объекта
            Graphics G = pictureBox1.CreateGraphics();
            //Очистка PictureBox1
            G.Clear(Color.White);

            //Описание и создание массива точек		 
            Point[] p = new Point[M];
            //Цикл по числу точек графика
            for (int n = 0; n < M; n++)
            {
                //Физические координаты
                double x = (double)n / M;
                double y = f(x);
                //Экранные координаты
                int xi = (int)(x0 + Mx * x);
                int yi = (int)(y0 + My * y);
                //заносим в массив вычисленные значения координат
                p[n] = new Point(xi, yi);
            }
            //коэффициент упругости графика
            float tensition = (float)TensitionNumericUpDown.Value;

            //рисование графика
            G.DrawCurve(Pens.Blue, p, tensition);
            //Рисование оси Х
            G.DrawLine(Pens.Black, x0, y0, x0 + Mx, y0);
            //Рисование оси Y
            G.DrawLine(Pens.Black, x0, y0, x0, y0 + My);

            //Разметка оси Х
            for (int n = 0; n <= 10; n++)
            {
                //физическая координата штриха
                double x = n / 10.0;
                //экранная координата штриха
                int xi = (int)(x0 + Mx * x);
                //Наносим штрих
                G.DrawLine(Pens.Black, xi, y0, xi, y0 + 4);
                //Наносим число
                G.DrawString(x.ToString(), font, brush, xi - 9, y0 + 4);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //шрифт берем установленный по умолчанию
            font = fontDialog1.Font;
            //создаем сплошную кисть черного цвета
            brush = new SolidBrush(Color.Black);

        }
    }
}
