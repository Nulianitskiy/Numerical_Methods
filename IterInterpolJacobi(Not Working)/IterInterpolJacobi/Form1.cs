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

namespace IterInterpolJacobi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int MatrixColumns(string file)// n - кол-во столбцов
        {
            StreamReader srN = new StreamReader(file);
            string line = srN.ReadLine();
            srN.Close();
            string[] entries = line.Split(' ');

            return entries.Length;
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

        void PrintExpandMatrix(double[,] Matrix)
        {
            int n = Matrix.GetLength(0);
            int k = Matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k - 1; j++)
                    richTextBox.Text += Matrix[i, j] + " ";
                richTextBox.Text += "\t" + Matrix[i, k-1] + "\n";
            }
            richTextBox.Text += "///////////////////////////\n";
        }//Вывод матрицы в текстбокс

        void Prepare(double[,] ExpMatrix)
        {
            int n = ExpMatrix.GetLength(0);
            int k = ExpMatrix.GetLength(1);

            for (int i = 0; i < n - 1; i++)
            {
                double x = ExpMatrix[i, i];
                for (int j = 0; j < k; j++)
                    ExpMatrix[i, j] /= x;
            }
        }

        void Jacobi(double[,] ExpMatrix, double[] b, double[] x, double eps)
        {
            int n = ExpMatrix.GetLength(0);
            double[] NextX = new double[n];
            int k = 0;
            double norm = 0;
            do
            {
                for (int i = 0; i < n; ++i)
                {
                    double sum = 0;
                    for (int j = 0; j < n; ++j)
                    {
                        if (i != j)
                        {
                            sum = sum + ExpMatrix[i, j] * x[j];
                        }
                    }
                    NextX[i] = (b[i] - sum);
                }

                norm = Math.Abs(NextX[0] - x[0]);
                for (int i = 0; i < n; ++i)
                {
                    if (Math.Abs(NextX[i] - x[i]) > norm)
                    {
                        norm = Math.Abs(NextX[i] - x[i]);
                    }
                    x[i] = NextX[i];
                }
                k++;
            } while (norm > eps);
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            string file = "In1.txt";
            int n = MatrixLines(file);
            int k = MatrixColumns(file);
            double eps = Double.Parse(textBox.Text);

            double[,] ExpMatrix = new double[n, k];
            MatrixReader(ExpMatrix, file);
            PrintExpandMatrix(ExpMatrix);

            double[] b = new double[n];
            double[] x = new double[n];
            Prepare(ExpMatrix);

            Jacobi(ExpMatrix, b, x, eps);

            PrintExpandMatrix(ExpMatrix);
        }
    }
}
