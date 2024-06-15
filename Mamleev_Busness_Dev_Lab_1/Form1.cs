using System.Windows.Forms;

namespace Mamleev_Busness_Dev_Lab_1
{
    public partial class Form1 : Form
    {
        private Font font;
        private SolidBrush brush;

        private void FontButton_Click(object sender, EventArgs e)
        {
            //���� ����� ������ �������� �������� ������ OK
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //�������� ��������� ������ �� ����������� ���� 
                font = fontDialog1.Font;
                //�������� ���� ������ �� ���� �� ����
                brush.Color = fontDialog1.Color;
            }
        }

        private double f(double x)
        {
            return Math.Log(1+Math.Pow(x,2))+Math.Pow(Math.Sin(x/3), 2);
        }
        private void GraphicButton_Click(object sender, EventArgs e)
        {
            //������ ��������� �������
            int x0 = 15;
            int y0 = (int)(pictureBox1.Height * 0.85);
            //������� �� ��� �
            int Mx = pictureBox1.Width - 2 * x0;
            //������� �� ��� Y
            int My = -y0 + 10;
            //����� ����� �������			
            int M = (int)PointsNumericUpDown.Value;

            //�������� ������������ �������
            Graphics G = pictureBox1.CreateGraphics();
            //������� PictureBox1
            G.Clear(Color.White);

            //�������� � �������� ������� �����		 
            Point[] p = new Point[M];
            //���� �� ����� ����� �������
            for (int n = 0; n < M; n++)
            {
                //���������� ����������
                double x = (double)n / M;
                double y = f(x);
                //�������� ����������
                int xi = (int)(x0 + Mx * x);
                int yi = (int)(y0 + My * y);
                //������� � ������ ����������� �������� ���������
                p[n] = new Point(xi, yi);
            }
            //����������� ��������� �������
            float tensition = (float)TensitionNumericUpDown.Value;

            //��������� �������
            G.DrawCurve(Pens.Blue, p, tensition);
            //��������� ��� �
            G.DrawLine(Pens.Black, x0, y0, x0 + Mx, y0);
            //��������� ��� Y
            G.DrawLine(Pens.Black, x0, y0, x0, y0 + My);

            //�������� ��� �
            for (int n = 0; n <= 10; n++)
            {
                //���������� ���������� ������
                double x = n / 10.0;
                //�������� ���������� ������
                int xi = (int)(x0 + Mx * x);
                //������� �����
                G.DrawLine(Pens.Black, xi, y0, xi, y0 + 4);
                //������� �����
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
            //����� ����� ������������� �� ���������
            font = fontDialog1.Font;
            //������� �������� ����� ������� �����
            brush = new SolidBrush(Color.Black);

        }
    }
}
