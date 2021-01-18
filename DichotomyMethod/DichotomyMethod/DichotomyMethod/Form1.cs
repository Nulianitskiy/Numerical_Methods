using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace DichotomyMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Func(double x)
        {
            return Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 3 * x + 11;
        }
        public void Graph(double a, double b)
        {

            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            for (double x = a; x <= b; x += 0.01)
            {
                list.Add(x, Func(x));
            }
            LineItem myCurve = pane.AddCurve("Function", list, Color.Blue, SymbolType.None);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double a = (tbA.Text != "") ? Convert.ToDouble(tbA.Text) : 0;
            double b = (tbB.Text != "") ? Convert.ToDouble(tbB.Text) : 0;
            double Eps = (tbEps.Text != "") ? Convert.ToDouble(tbEps.Text) : 0;

            Graph(a, b);

            int n = 0;
            double c = (a + b) / 2;

            while (Math.Abs(a-b) > Eps)
            {
                n++;

                if (Func(a) * Func(c) < 0) b = c;
                else a = c;

                c = (a + b) / 2;
            }
            label1.Text = "Количество итераций = " + n;
            label2.Text = "x = " + c;
        }
    }
}
