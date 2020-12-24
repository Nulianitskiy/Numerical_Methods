using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;

namespace LagrangeInterpol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int MatrixLines(string file)// кол-во строк
        {
            List<string> lines = File.ReadAllLines(file).ToList();
            return lines.Capacity;
        }

        void MatrixReader(double[,] Matrix, string file)
        {
            List<string> lines = File.ReadAllLines(file).ToList();
            int n = Matrix.GetLength(1);
            int i = 0;
            foreach (string line in lines)
            {
                string[] entries = line.Split(' ');

                for (int j = 0; j < n; j++)
                    Matrix[i, j] = Double.Parse(entries[j]);
                i++;
            }
        }//Чтение матрицы из файла
        void PrintMatrix(double[,] Matrix)
        {
            int n = Matrix.GetLength(0);
            int k = Matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                    richTextBox.Text += Matrix[i, j] + "   ";
                richTextBox.Text += "\n";
            }
            richTextBox.Text += "///////////////////////////\n";
        }//Вывод матрицы в текстбокс
        public double P(double[,] Matrix, double root)//Pn(xi) = E  yk  * Lk(xi)
        {                                            //     k=0 -> n
            int n = Matrix.GetLength(0);
            double c, s = 0;
            for (int i = 0; i < n; i++)
            {
                c = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        c *= (root - Matrix[j,0]) / (Matrix[i,0] - Matrix[j,0]);
                }
                s += c * Matrix[i, 1];
            }
            return s;
        }
        public double W(double[,] Matrix, double root)//W   (x) = (x - x0)(x-x1)(x-x2)........(x-xn)    ,x == root
        {                                            //  n+1                                             
            int n = Matrix.GetLength(0);

            double Rez = root - Matrix[0, 0];
            for (int i = 1; i < n; i++)
            {
                Rez *= root - Matrix[i, 0];
            }
            return Rez;
        }
        public void graf(double[,] Matrix)
        {
            int n = Matrix.GetLength(0);

            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            double xmin = -100;
            double xmax = 100;

            for (double x = xmin; x <= xmax; x += 0.01)
            {
                list.Add(x, P(Matrix, x));
            }
            LineItem myCurve = pane.AddCurve("LagrangeInterpol", list, Color.Blue, SymbolType.None);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "In3.txt";

            int n = MatrixLines(file);
            double[,] Matrix = new double[n, 2];

            MatrixReader(Matrix, file);
            richTextBox.Text = "Xi   Yi\n";
            PrintMatrix(Matrix);

            double root = Convert.ToDouble(textBox.Text);
            richTextBox.Text += "Корень = " + root;
            richTextBox.Text += "\n/////////////////////\n";
            richTextBox.Text += "P" + (n - 1) + "(" + root + ") = " + P(Matrix, root) + "\n";
            richTextBox.Text += "W" + (n) + "(" + root + ") = " + W(Matrix, root) + "\n";
            graf(Matrix);
            
        }

    }
}
