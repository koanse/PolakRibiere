using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Метод_Полака_Рибьера
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Function f;
                if (radioButton1.Checked)
                {
                    double a0, a1, a2, a3, a4, a5, a6;
                    a0 = double.Parse(tbA0.Text);
                    a1 = double.Parse(tbA1.Text);
                    a2 = double.Parse(tbA2.Text);
                    a3 = double.Parse(tbA3.Text);
                    a4 = double.Parse(tbA4.Text);
                    a5 = double.Parse(tbA5.Text);
                    f = new QuadFunction(a0, a1, a2, a3, a4, a5);
                }
                else
                {
                    double a, b;
                    a = double.Parse(tbA.Text);
                    b = double.Parse(tbB.Text);
                    f = new RosFunction(a, b);
                }
                PolRibMethod m = new PolRibMethod(f);
                
                double x1, x2, gradEps, xEps, fEps, machEps, lambdaMax;
                ExMatrix x;
                int maxIter;
                x1 = double.Parse(tbX1.Text);
                x2 = double.Parse(tbX2.Text);
                gradEps = double.Parse(tbGradEps.Text);
                xEps = double.Parse(tbXEps.Text);
                fEps = double.Parse(tbFEps.Text);
                machEps = double.Parse(tbMachEps.Text);
                lambdaMax = double.Parse(tbLambdaMax.Text);
                maxIter = int.Parse(tbMaxIter.Text);
                x = new ExMatrix(2, 1);
                x.Elements[0, 0] = x1;
                x.Elements[1, 0] = x2;
                m.GetOptimum(x, maxIter, gradEps, xEps, fEps, machEps, lambdaMax);
                listBox1.Items.Clear();
                listBox1.SuspendLayout();
                foreach (ExMatrix matr in m.xTrajectory)
                    listBox1.Items.Add(matr.Elements[0, 0].ToString("g") + " "
                        + matr.Elements[1, 0].ToString("g"));
                listBox1.ResumeLayout();

            }
            catch
            {
                MessageBox.Show("Ошибка оптимизации, проверьте исходные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}