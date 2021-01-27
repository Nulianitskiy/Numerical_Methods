using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace EulerMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Func(double x, double y)
        {
            return 6 * Math.Pow(x, 2) + 5 * x * y;
        }
        public void Graph(double x0, double y0, double step)
        {

            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.CurveList.Clear();
            PointPairList listFunc = new PointPairList();

            for (double x = 0; x <= 1; x += 0.001)
            {
                listFunc.Add(x, Func(x, x));
            }
            LineItem CurveFunc = pane.AddCurve("Function", listFunc, Color.Blue, SymbolType.None);

            PointPairList listEuler = new PointPairList();

            while(x0 <= 1)
            {
                listEuler.Add(x0, Func(x0, y0));

                y0 += step * Func(x0, y0);
                x0 += step;
            }

            LineItem CurveEuler = pane.AddCurve("EulerMethod", listEuler, Color.Red, SymbolType.None);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double x0 = (tbX0.Text != "") ? Convert.ToDouble(tbX0.Text) : 0;
            double y0 = (tbY0.Text != "") ? Convert.ToDouble(tbY0.Text) : 0;
            double step = (tbStep.Text != "") ? Convert.ToDouble(tbStep.Text) : 0;
            Graph(x0, y0, step);
        }
    }
}
