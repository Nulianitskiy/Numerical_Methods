using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace NewtonMethod_2F_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Func1(double x)//f(x)
        {

            return x * x - (Math.Cos(Math.PI * x));
        }

        double PFunc(double x)//f"(x)
        {
            return 2 * x + (1 / x);//2 производная от x*x-(cos(pi*x))
        }

        double Func2(double x)
        {

            return Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 3 * x + 11;
        }

        public void Graph(double a, double b)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.CurveList.Clear();

            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();

            for (double x = a; x <= b; x += 0.01)
            {
                list1.Add(x, Func1(x));
                list2.Add(x, Func2(x));
            }
            LineItem myCurve1 = pane.AddCurve("Функция1", list1, Color.Purple, SymbolType.None);//настройки графика
            LineItem myCurve2 = pane.AddCurve("Функция2", list2, Color.Blue, SymbolType.None);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int n = 0;
            double a = (textBoxA.Text != "") ? Convert.ToDouble(textBoxA.Text) : 0;
            double b = (textBoxB.Text != "") ? Convert.ToDouble(textBoxB.Text) : 0;
            double c;
            double Eps = (textBoxEps.Text != "") ? Convert.ToDouble(textBoxEps.Text) : 0;

            Graph(a, b);

            if (Func1(a) * Func2(a) > 0)
            {
                c = a;
            }
            else
            {
                c = b;
            }
            do
            {
                c = c - Func1(c) / PFunc(c);
                n++;
            }
            while (Math.Abs(Func1(c)) >= Eps);

            Answer.Text = "";
            Answer.Text += "Ответ = " + c + "\n";
            Answer.Text += "Кол-во итераций = " + n + "\n";
        }
    }
}
