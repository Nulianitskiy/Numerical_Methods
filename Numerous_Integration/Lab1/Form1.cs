using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Lab1
{
    public partial class Form1 : Form
    {
        GraphPane pane;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pane = z1.GraphPane;
        }

        double func(double x)
        {
            return Math.Pow(x, 2) + Math.Sin(x);
        }

        double Central_Squers_Integral(double a, double b, double n)
        {
            double sum = 0;            // сумма, результат вычисления интеграла.
            double h = (b - a) / n;    // вычисляем шаг - h
            for (int i = 0; i < n; i++)// в цикле применяем формулу центральных прямоугольников
            {
                sum += func(a + h * (i + 0.5)) * h; //складываем все суммы площадей прямоугольников
            }                                      //func(...) - результат значения, подставленного в функцию - высота
            return sum;                           //h - ширина
        }

        double Simpson_Parable_Integral(double a, double b, double n)
        {
            double h = (b - a) / n; // вычисляем шаг - h
            double sum = 0;     // сумма, результат вычисления интеграла.
            double x0 = a;      // правая граница подотрезка отрезка [a, b]
            double x1 = a + h;  // левая граница подотрезка отрезка [a, b]

            for (int i = 0; i < n; i++) // в цикле применяем формулу Симпсона
            {
                sum += func(x0) + 4 * func(x0 + h / 2) + func(x1);   //для каждого подотрезка, и складываем все полученные значения в общую сумму.
                x0 += h;    // сдвигаем левую и
                x1 += h;    // правую границу
            }

            return (h / 6) * sum;	// возвращаем сумму умноженную на (h/6)(по формуле), т.к. (h/6) общий множитель который можно вынести за скобки.
        }

        private void Create_Click(object sender, EventArgs e)
        {
            z1.GraphPane.CurveList.Clear();
            PointPairList list = new PointPairList();
            double xmin = Convert.ToDouble(textBoxA.Text);
            double xmax = Convert.ToDouble(textBoxB.Text);

            for (double x = xmin; x <= xmax; x += 0.1)
            {
                list.Add(x, func(x));
            }
            // !!!
            // Ось X будет пересекаться с осью Y на уровне Y = 0
            pane.XAxis.Cross = 0.0;

            // Ось Y будет пересекаться с осью X на уровне X = 0
            pane.YAxis.Cross = 0.0;

            // Отключим отображение первых и последних меток по осям
            pane.XAxis.Scale.IsSkipFirstLabel = true;
            pane.XAxis.Scale.IsSkipLastLabel = true;

            // Отключим отображение меток в точке пересечения с другой осью
            pane.XAxis.Scale.IsSkipCrossLabel = true;


            // Отключим отображение первых и последних меток по осям
            pane.YAxis.Scale.IsSkipFirstLabel = true;

            // Отключим отображение меток в точке пересечения с другой осью
            pane.YAxis.Scale.IsSkipLastLabel = true;
            pane.YAxis.Scale.IsSkipCrossLabel = true;

            // Спрячем заголовки осей
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;
            LineItem myCurve = pane.AddCurve("Function", list, Color.Blue, SymbolType.None);


            // !!! Установим заливку для кривой
            myCurve.Line.Fill = new ZedGraph.Fill(Color.Blue);

            z1.AxisChange();
            z1.Invalidate();

        }
        private void CSI_Click(object sender, EventArgs e)
        {
            double n = 1;
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double E = Convert.ToDouble(textBoxE.Text);
            while (Math.Abs(Central_Squers_Integral(a, b, 2 * n) - Central_Squers_Integral(a, b, n)) / 3 > E) n *= 2;
            n *= 2;                                    //Точность для формул прямоугольников равна 1/3 ( I2n - In)
            double Answer = Central_Squers_Integral(a, b, n);
            AnsCSI.Text = "Значение интеграла = " + Answer.ToString();

            nCSI.Text = "Колличество отрезков - " + n;

            hCSI.Text = "Длина шага - " + Math.Abs(a - b) / n;
        }

        private void Sim_Click(object sender, EventArgs e)
        {
            double n = 1;
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double E = Convert.ToDouble(textBoxE.Text);
            while (Math.Abs(Simpson_Parable_Integral(a, b, 2 * n) - Simpson_Parable_Integral(a, b, n)) / 15 > E) n *= 2;
            n *= 2;                                   //Точность для формулы Симпсона (парабол) равна 1/15 (I2n - In)
            double Answer = Simpson_Parable_Integral(a, b, n);
            AnsSIM.Text = "Значение интеграла = " + Answer.ToString();

            nSIM.Text = "Колличество отрезков - " + n;

            hSIM.Text = "Длина шага - " + Math.Abs(a - b) / n;
        }
    }
}
