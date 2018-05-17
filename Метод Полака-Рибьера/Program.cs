using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Globalization;

namespace Метод_Полака_Рибьера
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //RosFunction f = new RosFunction(100, 3);
            //QuadFunction f = new QuadFunction(1, 1, 1, 1, 1, 1);
            //PolRibMethod m = new PolRibMethod(f);
            //ExMatrix xInit = new ExMatrix(2, 1);
            //xInit.Elements[0, 0] = 2;
            //xInit.Elements[1, 0] = 8;
            //ExMatrix x = m.GetOptimum(xInit, 20, 0.00000000000001,
            //   0.000000000000001, 0.00000000000001, 0.00000000000001, 0.001);
        }
    }
    public class ExMatrix
    {
        int m, n;
        double[,] elements;
        public int M
        {
            get
            {
                return m;
            }
        }
        public int N
        {
            get
            {
                return n;
            }
        }
        public double[,] Elements
        {
            get
            {
                return elements;
            }
            set
            {
                if (value.GetLength(0) <= 0 || value.GetLength(1) <= 0)
                    throw new ArgumentException();
                this.elements = value;
                this.m = elements.GetLength(0);
                this.n = elements.GetLength(1);
            }
        }
        public ExMatrix() { }
        public ExMatrix(int n)
        {
            if (n <= 0)
                throw new ArgumentException();
            this.m = this.n = n;
            this.elements = new double[n, n];
            for (int i = 0; i < n; i++)
                elements[i, i] = 1;
        }
        public ExMatrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            if (m <= 0 || n <= 0)
                throw new ArgumentException();
            elements = new double[m, n];
        }
        public ExMatrix(double[,] elements)
        {
            this.m = elements.GetLength(0);
            this.n = elements.GetLength(1);
            if (m <= 0 || n <= 0)
                throw new ArgumentException();
            this.elements = elements;
        }
        public ExMatrix(ExMatrix[] matrices)
        {
            int rows = matrices[0].M;
            int cols = 0;
            foreach (ExMatrix matr in matrices)
            {
                if (matr.M != rows)
                    throw new ArgumentException();
                cols += matr.N;
            }
            this.elements = new double[rows, cols];
            this.m = rows;
            this.n = cols;
            cols = 0;
            foreach (ExMatrix matr in matrices)
            {
                for (int j = 0; j < matr.N; j++)
                    for (int i = 0; i < matr.M; i++)
                        elements[i, cols + j] = matr.Elements[i, j];
                cols += matr.N;
            }
        }
        public ExMatrix(ExMatrix matr)
        {
            m = matr.m;
            n = matr.n;
            this.elements = (double[,])matr.elements.Clone();
        }
        public double GetEuclNorm()
        {
            double sum = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    sum += elements[i, j] * elements[i, j];
            return Math.Sqrt(sum);
        }
        public static ExMatrix operator +(ExMatrix matr1, ExMatrix matr2)
        {
            if (matr1.M != matr2.M || matr1.N != matr2.N)
                throw new ArgumentException();
            ExMatrix res = new ExMatrix(matr1.M, matr1.N);
            for (int i = 0; i < res.M; i++)
                for (int j = 0; j < res.N; j++)
                    res.Elements[i, j] = matr1.Elements[i, j]
                        + matr2.Elements[i, j];
            return res;
        }
        public static ExMatrix operator -(ExMatrix matr1, ExMatrix matr2)
        {
            if (matr1.M != matr2.M || matr1.N != matr2.N)
                throw new ArgumentException();
            ExMatrix res = new ExMatrix(matr1.M, matr1.N);
            for (int i = 0; i < res.M; i++)
                for (int j = 0; j < res.N; j++)
                    res.Elements[i, j] = matr1.Elements[i, j]
                        - matr2.Elements[i, j];
            return res;
        }
        public static ExMatrix operator *(ExMatrix matr1, ExMatrix matr2)
        {
            if (matr1.N != matr2.M)
                throw new ArgumentException();
            ExMatrix res = new ExMatrix(matr1.M, matr2.N);
            for (int i = 0; i < res.M; i++)
                for (int j = 0; j < res.N; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < matr1.N; k++)
                        sum += matr1.Elements[i, k] * matr2.Elements[k, j];
                    res.Elements[i, j] = sum;
                }
            return res;
        }
        public static ExMatrix operator *(ExMatrix matr1, double x)
        {
            ExMatrix res = new ExMatrix(matr1.M, matr1.N);
            for (int i = 0; i < res.M; i++)
                for (int j = 0; j < res.N; j++)
                    res.Elements[i, j] = matr1.Elements[i, j] * x;
            return res;
        }
    }
    public class PolRibMethod
    {
        Function func;
        ExMatrix x, xNext, grad, gradPrev, s, sPrev;
        double fCur, fNext;
        public ArrayList xTrajectory;
        public PolRibMethod(Function func)
        {
            this.func = func;
            xTrajectory = new ArrayList();
        }
        public ExMatrix GetOptimum(ExMatrix xInit, int maxIter,
            double gradEps, double xEps, double fEps, double machEps,
            double lambdaMax)
        {
            try
            {
                x = xInit;
                xTrajectory.Add(x);
                sPrev = new ExMatrix(x.M, 1);
                sPrev.Elements.Initialize();

                for (int i = 0; i < maxIter; i++)
                {
                    grad = func.GetGrad(x, machEps);
                    fCur = func.GetValue(x);
                    ExMatrix gradDelta;
                    double gamma = 0;
                    if (i > 0)
                    {
                        gradDelta = grad - gradPrev;
                        for (int j = 0; j < grad.M; j++)
                            gamma += grad.Elements[j, 0] *
                                gradDelta.Elements[j, 0];
                        double gradEuclNorm = gradPrev.GetEuclNorm();
                        gamma /= gradEuclNorm * gradEuclNorm;
                    }
                    s = grad * -1 + sPrev * gamma;

                    double sEuclNorm = s.GetEuclNorm();
                    double f1, f2, f3;
                    f1 = func.GetValue(x);
                    f2 = func.GetValue(x + s * (lambdaMax / sEuclNorm / 2));
                    f3 = func.GetValue(x + s * (lambdaMax / sEuclNorm));
                    double lambda = GetQuadInterpOptimum(0,
                        lambdaMax / sEuclNorm / 2, lambdaMax / sEuclNorm,
                        f1, f2, f3);
                    xNext = x + s * lambda;
                    fNext = func.GetValue(xNext + s * lambda);
                    ExMatrix xDelta = xNext - x;
                    x = xNext;
                    sPrev = s;
                    gradPrev = grad;
                    xTrajectory.Add(x);
                    if (grad.GetEuclNorm() <= gradEps ||
                        xDelta.GetEuclNorm() < xEps ||
                        Math.Abs(fNext - fCur) < fEps)
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка оптимизации");
            }
            return x;
        }
        double GetQuadInterpOptimum(double x1, double x2, double x3,
            double f1, double f2, double f3)
        {
            double a = (x3 - x2) * f1 + (x1 - x3) * f2 + (x2 - x1) * f3;
            a /= (x1 - x2) * (x2 - x3) * (x3 - x1);
            if (a <= 0)
                if (f1 < f3) return x1;
                else return x3;
            double res = 0.5f * ((x2 * x2 - x3 * x3) * f1 +
                (x3 * x3 - x1 * x1) * f2 + (x1 * x1 - x2 * x2) * f3);
            res /= ((x2 - x3) * f1 + (x3 - x1) * f2 + (x1 - x2) * f3);
            return res;
        }
        double PowellMethod(double lambdaInit, double lambdaDelta,
            double eps1, double eps2,
            ExMatrix xVector, ExMatrix sVector)
        {
            double[] lambda, f;
            lambda = new double[3];
            f = new double[3];
            lambda[0] = lambdaInit;
            while(true)
            {
                lambda[1] = lambda[0] + lambdaDelta;
                f[0] = func.GetValue(xVector + sVector * lambda[0]);
                f[1] = func.GetValue(xVector + sVector * lambda[1]);
                if (f[0] > f[1])
                    lambda[2] = lambda[0] + 2 * lambdaDelta;
                else
                    lambda[2] = lambda[0] - lambdaDelta;
                f[2] = func.GetValue(xVector + sVector * lambda[2]);
                while (true)
                {
                    double lambdaMin = lambda[0], fMin = f[0];
                    for (int i = 0; i < 3; i++)
                        if (f[i] <= fMin)
                        {
                            fMin = f[i];
                            lambdaMin = lambda[i];
                        }
                    double lambdaOpt = 0.5 * (lambda[1] * lambda[1] - lambda[2] * lambda[2]) * f[0] +
                        (lambda[2] * lambda[2] - lambda[0] * lambda[0]) * f[1] +
                        (lambda[0] * lambda[0] - lambda[1] * lambda[1]) * f[2];
                    double denominator = (lambda[1] - lambda[2]) * f[0] +
                        (lambda[2] - lambda[0]) * f[1] +
                        (lambda[0] - lambda[1]) * f[2];
                    if (denominator == 0)
                    {
                        lambda[0] = lambdaMin;
                        break;
                    }
                    lambdaOpt /= denominator;
                    double fOpt = func.GetValue(xVector + sVector * lambdaOpt);

                    if (Math.Abs((fMin - fOpt) / fOpt) < eps1 &&
                        Math.Abs((lambdaMin - lambdaOpt) / lambdaOpt) < eps2)
                        return lambdaOpt;
                    else
                    {
                        if (lambdaOpt >= lambda[0] && lambdaOpt <= lambda[2])
                        {
                            double[] lambdaArr = new double[4];
                            double lambdaBest;
                            for (int i = 0; i < 3; i++)
                                lambdaArr[i] = lambda[i];
                            if (fMin < fOpt)
                            {
                                lambdaBest = lambdaMin;
                                lambdaArr[3] = lambdaOpt;
                            }
                            else
                            {
                                lambdaBest = lambdaOpt;
                                lambdaArr[3] = lambdaMin;
                            }

                            lambda[1] = lambdaBest;
                            double delta1 = double.MaxValue;
                            double delta2 = double.MaxValue;
                            for (int i = 0; i < 4; i++)
                            {
                                double curDelta = lambdaBest - lambdaArr[i];
                                if (curDelta > 0 && curDelta < delta1)
                                {
                                    lambda[0] = lambdaArr[i];
                                    delta1 = curDelta;
                                }
                                curDelta *= -1;
                                if (curDelta > 0 && curDelta < delta2)
                                {
                                    lambda[2] = lambdaArr[i];
                                    delta2 = curDelta;
                                }
                            }
                        }
                        else
                        {
                            lambda[0] = lambdaOpt;
                            break;
                        }                            
                    }
                }
            }
        }
    }
    public class Function
    {
        public virtual double GetValue(ExMatrix x)
        {
            return 0;
        }
        public ExMatrix GetGrad(ExMatrix x, double machEps)
        {
            if (x.N > 1)
                throw new ArgumentException();
            ExMatrix res = new ExMatrix(x.M, 1);
            double f1 = GetValue(x);
            for (int i = 0; i < x.M; i++)
            {
                double oldValue = x.Elements[i, 0];
                x.Elements[i, 0] += machEps;
                double f2 = GetValue(x);
                x.Elements[i, 0] = oldValue;
                res.Elements[i, 0] = (f2 - f1) / machEps;
            }
            return res;
        }
    }
    public class RosFunction : Function
    {
        double a, b;
        public RosFunction(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double GetValue(ExMatrix x)
        {
            if (x.N > 1)
                throw new ArgumentException();
            double x1 = x.Elements[0, 0];
            double x2 = x.Elements[1, 0];
            return a * (x2 - x1 * x1) * (x2 - x1 * x1) +
                (b - x1) * (b - x1);
        }
    }
    public class QuadFunction : Function
    {
        double a0, a1, a2, a3, a4, a5;
        public QuadFunction(double a0, double a1,
            double a2, double a3, double a4, double a5)
        {
            this.a0 = a0;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
            this.a5 = a5;
        }
        public override double GetValue(ExMatrix x)
        {
            if (x.N > 1)
                throw new ArgumentException();
            double x1 = x.Elements[0, 0];
            double x2 = x.Elements[1, 0];
            return a0 * x1 * x1 + a1 * x2 * x2 +
                a2 * x1 * x2 + a3 * x1 + a4 * x2 + a5;
        }
    }
}